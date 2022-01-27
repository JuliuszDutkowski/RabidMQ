using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace RabidMQ
{
    class DBStuff
    {
        static readonly string connectionString = "server=127.0.0.1; port = 3306; username=root; password=; database=rabidmqdb;";

        private static MySqlConnection CreateConnection()
        {
            return new MySqlConnection(connectionString);
        }

        //sprawdza, czy istnieje w bazie użytkownik o danej nazwie. Jeżeli nie, dodaje użytkownika do bazy danych
        public static bool AddUser(string username, string password)
        {
            MySqlDataReader reader;
            MySqlConnection con = CreateConnection();
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * FROM users where username=@username";
            cmd.Parameters.AddWithValue("@username", username);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Username already taken. Choose a different name");
                con.Close();
                return false;
            }
            MySqlConnection con1 = CreateConnection();
            con1.Open();

            MySqlCommand cmd1 = con1.CreateCommand();
            cmd1.CommandText = "INSERT INTO users" + "(username, PASSWORD) VALUES(@username, @password);";
            cmd1.Parameters.AddWithValue("@username", username);
            cmd1.Parameters.AddWithValue("@password", password);
            cmd1.ExecuteNonQuery();
            con1.Close();
            return true;
        }

        //sprawdza, czy istnieje w bazie taki użytkownik i loguje
        public static bool LogIn(string username, string password)
        {
            MySqlDataReader dr;
            MySqlConnection con = CreateConnection();
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * FROM users where username=@username and PASSWORD=@password";
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }

        }

        //dodanie użytkownika do kontaktów
        public static void AddContact(string username, string contactName)
        {
            string id1;
            string id2;

            //sprawdza, czy użytkownik nie próbuje dodać samego siebie
            if (username == contactName)
            {
                MessageBox.Show("You can't add yourself to your contacts");
                return;
            }

            //sprawdza, czy użytkownik istnieje - to nie powinno wystąpić po zalogowaniu, ale dodane na wszelki wypadek
            MySqlDataReader reader1;
            MySqlConnection con1 = CreateConnection();
            con1.Open();
            MySqlCommand cmd1 = con1.CreateCommand();
            cmd1.CommandText = "Select * FROM users where username=@username";
            cmd1.Parameters.AddWithValue("@username", username);
            reader1 = cmd1.ExecuteReader();
            if (reader1.Read())
                id1 = reader1.GetString("userid");
            else
            {
                MessageBox.Show("User failure");
                return;
            }
            con1.Close();

            //sprawdza, czy istnieje w bazie użytkownik z nazwą, którą użytkownik aplikacji próbuje dodać do kontaków
            MySqlDataReader reader2;
            MySqlConnection con2 = CreateConnection();
            con2.Open();
            MySqlCommand cmd2 = con2.CreateCommand();           
            cmd2.CommandText = "Select * FROM users where username=@username";
            cmd2.Parameters.AddWithValue("@username", contactName);
            reader2 = cmd2.ExecuteReader();
            if(reader2.Read())
                id2 = reader2.GetString("userid");
            else
            {
                MessageBox.Show("There is no such user");
                return;
            }
            con2.Close();

            //sprawdza, czy użytkownik nie próbuje dodać do kontaktów osoby, którą w kontaktach już ma
            MySqlConnection con3 = CreateConnection();
            con3.Open();
            MySqlDataReader reader3;
            MySqlCommand cmd3 = con3.CreateCommand();
            cmd3.CommandText = "Select * FROM contacts WHERE (1userid=@1id OR 2userid=@2id) AND (1userid=@11id OR 2userid=@22id)";
            cmd3.Parameters.AddWithValue("@1id", id1);
            cmd3.Parameters.AddWithValue("@2id", id1);
            cmd3.Parameters.AddWithValue("@11id", id2);
            cmd3.Parameters.AddWithValue("@22id", id2);
            reader3 = cmd3.ExecuteReader();
            if(reader3.Read())
            {
                MessageBox.Show("You have already added this user");
                return;
            }
            con3.Close();

            //dodaje kontakt do bazy danych
            MySqlConnection con4 = CreateConnection();
            con4.Open();
            MySqlCommand cmd4 = con4.CreateCommand();
            cmd4.CommandText = "INSERT INTO contacts" + "(1userid, 2userid) VALUES(@1userid, @2userid);";
            cmd4.Parameters.AddWithValue("@1userid", id1);
            cmd4.Parameters.AddWithValue("@2userid", id2);
            cmd4.ExecuteNonQuery();
            con4.Close();
        }

        //wyświetlanie listy kontaktów użytkownika
        //każdy kontakt wyświetlony jest jako nowa kontrolka label z metodą wywołującą ładowanie
        //wiadomości między użytkownikami przy kliknięciu
        public static void LoadContacts(string username, Panel panel)
        {
            int x = 10;
            int y = 10;
            string contact = "";
            int i = 0;
            int id;

            //znalezienie id użytkownika w bazie danych i przypisanie go do zmiennej id
            MySqlDataReader dr;
            MySqlConnection con1 = CreateConnection();
            con1.Open();
            MySqlCommand cmd1 = con1.CreateCommand();
            cmd1.CommandText = "Select userid FROM users where username=@username";
            cmd1.Parameters.AddWithValue("@username", username);
            dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                id = dr.GetInt32(0);
            }
            else
            {
                MessageBox.Show("User Failure");
                return;
            }
            con1.Close();

            //ładownie kontaktów utworzonych przez użytkownika
            MySqlConnection con = CreateConnection();
            con.Open();
            string query = "SELECT users.username FROM users left join contacts on contacts.2userid = users.userid where 1userid = " + id;
            MySqlCommand cmd = new MySqlCommand(query, con);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string sth1 = reader.GetString(0);
                    contact = sth1;
                    Label label = new Label();
                    label.Location = new Point(x, y);
                    label.Name = "label" + i;
                    label.Text = contact;
                    label.Width = 320;
                    label.Font = new Font("Calibri", 16);
                    label.ForeColor = Color.FromArgb(255, 237, 28, 36);
                    label.Click += new EventHandler(label_Click);
                    panel.Controls.Add(label);
                    y += 20;

                    Panel panel1 = new Panel();
                    panel1.Name = "panel1" + i;
                    panel1.BackColor = Color.FromArgb(255, 237, 28, 36);
                    panel1.Location = new Point(0, label.Location.Y+label.Height+15);
                    panel1.Size = new Size(390, 1);
                    panel.Controls.Add(panel1);
                    y += 30;

                    i++;
                }
            }
            con.Close();

            //ładowanie kontaktów, do których użytkownik został dodany
            MySqlConnection con2 = CreateConnection();
            con2.Open();
            string query2 = "SELECT users.username FROM users left join contacts on contacts.1userid = users.userid where 2userid = " + id;
            MySqlCommand cmd2 = new MySqlCommand(query2, con2);
            using (var reader2 = cmd2.ExecuteReader())
            {
                while (reader2.Read())
                {
                    string sth1 = reader2.GetString(0);
                    contact = sth1;
                    Label label = new Label();
                    label.Location = new Point(x, y);
                    label.Name = "label" + i;
                    label.Text = contact;
                    label.Width = 320;
                    label.Font = new Font("Calibri", 16);
                    label.ForeColor = Form1.czerwony;
                    label.Click += new EventHandler(label_Click);
                    panel.Controls.Add(label);
                    y += 20;

                    Panel panel1 = new Panel();
                    panel1.Name = "panel1" + i;
                    panel1.BackColor = Form1.czerwony;
                    panel1.Location = new Point(0, label.Location.Y + label.Height + 15);
                    panel1.Size = new Size(390, 1);
                    panel.Controls.Add(panel1);
                    y += 30;

                    i++;
                }
            }
            con2.Close();

            //kliknięcie label z nazwą kontaktu
            void label_Click(Object sender, EventArgs e)
            {
                LoadMessages(username, contact, sender);
                Label label = sender as Label;
                Form1.uuser2 = label.Text;
                Form1.exchangeName = GetExchangeName(username, label.Text);

                RabbitStuff.userName = Form1.uuser;
                RabbitStuff.userName2 = label.Text;
                RabbitStuff.CreateConnection();
                RabbitStuff.DeclareExchange(Form1.exchangeName);
                RabbitStuff.DeclareQueue(GetQueueName(RabbitStuff.userName2, RabbitStuff.userName)); //Tu zmieniłem
                RabbitStuff.BindQueue(Form1.exchangeName, GetQueueName(RabbitStuff.userName2, RabbitStuff.userName));
                RabbitStuff.Subscribe(GetQueueName(RabbitStuff.userName2, RabbitStuff.userName));
            }
        }

        //ładowanie wiadomości między użytkownikami
        //każda wiadomość jest wyświetlona jako 2 kontrolki label
        //pierwsza z nich pokazuje, kto wysłał wiadomość, druga pokazuje treść wiadomości
        public static void LoadMessages(string user, string contact, Object sender)
        {
            Label label1 = sender as Label;
            string who = label1.Text;
            int id = 0;
            int id2 = 0;

            //pobranie id użytkownika aplikacji
            MySqlDataReader dr;
            MySqlConnection con1 = CreateConnection();
            con1.Open();
            MySqlCommand cmd1 = con1.CreateCommand();
            cmd1.CommandText = "Select userid FROM users where username=@username";
            cmd1.Parameters.AddWithValue("@username", user);
            dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                id = dr.GetInt32(0);
            }
            con1.Close();

            //pobranie id rozmówcy
            MySqlDataReader dr2;
            MySqlConnection con2 = CreateConnection();
            con2.Open();
            MySqlCommand cmd2 = con2.CreateCommand();
            cmd2.CommandText = "Select userid FROM users where username=@who";
            cmd2.Parameters.AddWithValue("@who", who);
            dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                id2 = dr2.GetInt32(0);
            }
            con2.Close();

            //odwołanie do różnych kontrolek z Form1
            Panel panelContacts = Application.OpenForms["Form1"].Controls["panelContacts"] as Panel;
            Panel panelMessages = Application.OpenForms["Form1"].Controls["panelMessages"] as Panel;
            Button buttonBack3 = Application.OpenForms["Form1"].Controls["buttonBack3"] as Button;
            Button buttonBack4 = Application.OpenForms["Form1"].Controls["buttonBack4"] as Button;
            Button buttonSend = Application.OpenForms["Form1"].Controls["buttonSend"] as Button;
            TextBox textBoxMessage = Application.OpenForms["Form1"].Controls["textBoxMessage"] as TextBox;

            //włączanie i wyłączanie poszczególnych kontrolek
            Form1.TurnOff(panelContacts);
            Form1.TurnOn(panelMessages);
            Form1.TurnOn(buttonBack4);
            Form1.TurnOff(buttonBack3);
            Form1.TurnOn(buttonSend);
            Form1.TurnOn(textBoxMessage);

            //pobranie wiadomości, w których uczestniczył użytkownik
            MySqlConnection con = CreateConnection();
            con.Open();
            string query = "Select users.username, messageid, user1id, user2id, text from " +
                "messagehistory left join users on messagehistory.user1id = users.userid where (messagehistory.user1id = @id1 and messagehistory.user2id = @id2) or (messagehistory.user2id = @id1 and messagehistory.user1id = @id2)";

            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id1", id);
            cmd.Parameters.AddWithValue("@id2", id2);

            int x = 10;
            int y = 10;
            int i = 0;

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    int uuuser1 = reader.GetInt32(2);
                    int uuuser2 = reader.GetInt32(3);
                    string mmmsage = reader.GetString(4);
                    string uuuser3 = reader.GetString(0);
                    // wyświetlenie wiadomości wysłanych przez użytkownika aplikacji
                    if(uuuser1 == id && uuuser2 == id2)
                    {
                        Label label = new Label();
                        label.Location = new Point(x, y);
                        label.Name = "label" + i;
                        label.Text = "You:";
                        label.Font = new Font("Calibri", 12);
                        label.ForeColor = Form1.niebieski;
                        label.AutoSize = true;
                        label.MaximumSize = new Size(70, 30);
                        panelMessages.Controls.Add(label);

                        Label label2 = new Label();
                        label2.Location = new Point(80, y);
                        label2.Name = "label2" + i;
                        label2.Font = new Font("Calibri", 12);
                        label2.ForeColor = Form1.niebieski;
                        label2.AutoSize = true;
                        label2.MaximumSize = new Size(320 - label2.Width, 200);
                        label2.Text = mmmsage;
                        panelMessages.Controls.Add(label2);
                        if (label.Height > label2.Height)
                            y += label.Height + 10;
                        else
                            y += label2.Height + 10;

                        i++;
                    }
                    else
                    //wyświetlenie wiadomości wysłanych przez rozmówcę
                        if(uuuser2 == id && uuuser1 == id2)
                    {
                        Label label = new Label();
                        label.Location = new Point(x, y);
                        label.Name = "label" + i;
                        label.Text = uuuser3 + ":";
                        label.Font = new Font("Calibri", 12);
                        label.ForeColor = Form1.czerwony;
                        label.AutoSize = true;
                        label.MaximumSize = new Size(70, 200);
                        panelMessages.Controls.Add(label);

                        Label label2 = new Label();
                        label2.Location = new Point(80, y);
                        label2.Name = "label2" + i;
                        label2.Font = new Font("Calibri", 12);
                        label2.ForeColor = Form1.czerwony;
                        label2.AutoSize = true;
                        label2.MaximumSize = new Size(320 - label2.Width, 200);
                        label2.Text = mmmsage;
                        panelMessages.Controls.Add(label2);
                        if (label.Height > label2.Height)
                            y += label.Height + 10;
                        else
                            y += label2.Height + 10;

                        i++;
                    }
                }
            }
            con.Close();
            panelMessages.VerticalScroll.Value = panelMessages.VerticalScroll.Maximum;
        }

        //zapisanie wiadomości do bazy danych po jej wysłaniu
        public static void SaveMessage(string sender, string receiver, string messagetext)
        {
            string id1;
            string id2;

            //pobranie użytkownika aplikacji z bazy danych i przypisanie jego id do zmiennej
            MySqlDataReader reader1;
            MySqlConnection con1 = CreateConnection();
            con1.Open();
            MySqlCommand cmd1 = con1.CreateCommand();
            cmd1.CommandText = "Select * FROM users where username=@username";
            cmd1.Parameters.AddWithValue("@username", sender);
            reader1 = cmd1.ExecuteReader();
            if (reader1.Read())
                id1 = reader1.GetString("userid");
            else
            {
                MessageBox.Show("User failure");
                return;
            }
            con1.Close();

            //pobranie rozmówcy z bazy danych i przypisanie jego id do zmiennej
            MySqlDataReader reader2;
            MySqlConnection con2 = CreateConnection();
            con2.Open();
            MySqlCommand cmd2 = con2.CreateCommand();
            cmd2.CommandText = "Select * FROM users where username=@username";
            cmd2.Parameters.AddWithValue("@username", receiver);
            reader2 = cmd2.ExecuteReader();
            if (reader2.Read())
                id2 = reader2.GetString("userid");
            else
            {
                MessageBox.Show("There is no such user");
                return;
            }
            con2.Close();

            //zachowanie wiadomości do bazy danych
            MySqlConnection con3 = CreateConnection();
            con3.Open();
            MySqlCommand cmd3 = con3.CreateCommand();
            cmd3.CommandText = "INSERT INTO messagehistory" + "(user1id, user2id, text) VALUES(@1userid, @2userid, @message);";
            cmd3.Parameters.AddWithValue("@1userid", id1);
            cmd3.Parameters.AddWithValue("@2userid", id2);
            cmd3.Parameters.AddWithValue("@message", messagetext);
            cmd3.ExecuteNonQuery();
            con3.Close();

            RabbitStuff.SendMessage(messagetext, RabbitStuff.userName2, Form1.exchangeName);
        }

        //pobranie nazwy dla exchange zależnej od kontaktu,
        //ale niezależnej od tego, kto utworzył kontakt
        public static string GetExchangeName(string user, string user2)
        {
            string exchangeName;
            int id1;
            int id2;
            MySqlDataReader reader;
            MySqlConnection con = CreateConnection();
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            string query = "Select userid from users where username = @username";
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@username", user);
            reader = cmd.ExecuteReader();
            if (reader.Read())
                id1 = reader.GetInt32(0);
            else
            {
                MessageBox.Show("Failure");
                con.Close();
                return null;
            }
            con.Close();

            MySqlDataReader reader1;
            MySqlConnection con1 = CreateConnection();
            con1.Open();
            MySqlCommand cmd1 = con1.CreateCommand();
            string query1 = "Select userid from users where username = @username";
            cmd1.CommandText = query1;
            cmd1.Parameters.AddWithValue("@username", user2);
            reader1 = cmd1.ExecuteReader();
            if (reader1.Read())
                id2 = reader1.GetInt32(0);
            else
            {
                MessageBox.Show("Failure");
                con1.Close();
                return null;
            }
            con1.Close();

            MySqlDataReader reader2;
            MySqlConnection con2 = CreateConnection();
            con2.Open();
            MySqlCommand cmd2 = con2.CreateCommand();
            string query2 = "Select 1userid, 2userid from contacts where " +
                "(1userid = @1id and 2userid = @2id) or (1userid = @2id and 2userid = @1id)";
            cmd2.CommandText = query2;
            cmd2.Parameters.AddWithValue("@1id", id1);
            cmd2.Parameters.AddWithValue("@2id", id2);
            reader2 = cmd2.ExecuteReader();
            if (reader2.Read())
                exchangeName = reader2.GetInt32(0) + "-" + reader2.GetInt32(1);
            else
            {
                MessageBox.Show("Failure");
                con2.Close();
                return null;
            }
            con2.Close();
            return exchangeName;
        }

        //utworzenie nazwy kolejki
        static string GetQueueName(string user, string user2)
        {
            string queueName = user + "-" + user2 + "-queue";
            return queueName;
        }
    }
}
