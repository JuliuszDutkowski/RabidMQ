namespace RabidMQ
{
    public partial class Form1 : Form
    {
        public static string uuser = "";
        public static string uuser2 = "";
        public static string exchangeName = "";
        public static readonly Color czerwony = Color.FromArgb(255, 237, 28, 36);
        public static readonly Color bialy = Color.FromArgb(255, 255, 255, 255);
        public static readonly Color transparent = Color.FromArgb(0, 255, 255, 255);
        public static readonly Color niebieski = Color.FromArgb(255, 0, 162, 232);

        public Form1()
        {
            InitializeComponent();
            this.Width = 400;
            this.Height = 600;
            panel1.Width = 600;
            panel1.Height = 70;
            panel1.Location = new Point(0, 5);

            Font buttonFont = new Font("Calibri bold", 20);
            Font labelFont = new Font("Calibri", 16);

            //ustawienie wygl¹du, po³o¿enia i w³aœciwoœci kontrolek
            buttonLogIn1.Left = (this.ClientSize.Width - buttonLogIn1.Width) / 2;
            buttonLogIn1.Top = 200;
            buttonLogIn1.BackColor = czerwony;
            buttonLogIn1.ForeColor = bialy;
            buttonLogIn1.TabStop = false;
            buttonLogIn1.Font = buttonFont;
            buttonLogIn1.FlatAppearance.BorderColor = transparent;
            buttonLogIn1.FlatAppearance.BorderSize = 0;

            buttonRegister1.Left = (this.ClientSize.Width - buttonRegister1.Width) / 2;
            buttonRegister1.Top = 380;
            buttonRegister1.BackColor = czerwony;
            buttonRegister1.ForeColor = bialy;
            buttonRegister1.TabStop = false;
            buttonRegister1.Font = buttonFont;
            buttonRegister1.FlatAppearance.BorderColor = transparent;
            buttonRegister1.FlatAppearance.BorderSize = 0;

            buttonLogin2.Left = (this.ClientSize.Width - buttonRegister1.Width) / 2;
            buttonLogin2.Top = 380;
            buttonLogin2.BackColor = czerwony;
            buttonLogin2.ForeColor = bialy;
            buttonLogin2.TabStop = false;
            buttonLogin2.Font = buttonFont;
            buttonLogin2.FlatAppearance.BorderColor = transparent;
            buttonLogin2.FlatAppearance.BorderSize = 0;

            buttonRegister2.Left = (this.ClientSize.Width - buttonRegister1.Width) / 2;
            buttonRegister2.Top = 380;
            buttonRegister2.BackColor = czerwony;
            buttonRegister2.ForeColor = bialy;
            buttonRegister2.TabStop = false;
            buttonRegister2.Font = buttonFont;
            buttonRegister2.FlatAppearance.BorderColor = transparent;
            buttonRegister2.FlatAppearance.BorderSize = 0;

            textBoxLogIn.Left = (this.ClientSize.Width - textBoxLogIn.Width) / 2;
            textBoxLogIn.Top = 200;

            textBoxPassword.Left = (this.ClientSize.Width - textBoxPassword.Width) / 2;
            textBoxPassword.Top = 300;
            textBoxPassword.PasswordChar = '*';

            labelLogIn.Font = labelFont;
            labelLogIn.ForeColor = czerwony;
            labelLogIn.Left = textBoxLogIn.Left - 5;
            labelLogIn.Top = textBoxLogIn.Top - 32;

            labelRegister.Font = labelFont;
            labelRegister.ForeColor = czerwony;
            labelRegister.Left = textBoxPassword.Left - 5;
            labelRegister.Top = textBoxPassword.Top - 32;

            buttonBack1.Left = 0;
            buttonBack1.Top = panel1.Bottom - 3;
            buttonBack1.BackColor = czerwony;
            buttonBack1.ForeColor = bialy;
            buttonBack1.TabStop = false;
            buttonBack1.Font = labelFont;
            buttonBack1.FlatAppearance.BorderColor = transparent;
            buttonBack1.FlatAppearance.BorderSize = 0;

            labelRegistered.Width = 240;
            labelRegistered.Height = 80;
            labelRegistered.Font = labelFont;
            labelRegistered.ForeColor = czerwony;
            labelRegistered.AutoSize = false;
            labelRegistered.TextAlign = ContentAlignment.MiddleCenter;
            labelRegistered.Dock = DockStyle.None;
            labelRegistered.Left = (this.ClientSize.Width - labelRegistered.Width) / 2;
            labelRegistered.Top = 180;

            buttonRegistered.Left = (this.ClientSize.Width - buttonRegistered.Width) / 2;
            buttonRegistered.Top = 380;
            buttonRegistered.BackColor = czerwony;
            buttonRegistered.ForeColor = bialy;
            buttonRegistered.TabStop = false;
            buttonRegistered.Font = buttonFont;
            buttonRegistered.FlatAppearance.BorderColor = transparent;
            buttonRegistered.FlatAppearance.BorderSize = 0;

            labelWelcome.Width = 240;
            labelWelcome.Height = 80;
            labelWelcome.Top = 120;
            labelWelcome.Font = buttonFont;
            labelWelcome.ForeColor = czerwony;
            labelWelcome.AutoSize = false;
            labelWelcome.TextAlign = ContentAlignment.MiddleCenter;
            labelWelcome.Dock = DockStyle.None;
            labelWelcome.Left = (this.ClientSize.Width - labelWelcome.Width) / 2;

            buttonContacts.Left = (this.ClientSize.Width - buttonContacts.Width) / 2;
            buttonContacts.Top = 240;
            buttonContacts.BackColor = czerwony;
            buttonContacts.ForeColor = bialy;
            buttonContacts.TabStop = false;
            buttonContacts.Font = buttonFont;
            buttonContacts.FlatAppearance.BorderColor = transparent;
            buttonContacts.FlatAppearance.BorderSize = 0;

            buttonAdd.Left = (this.ClientSize.Width - buttonAdd.Width) / 2;
            buttonAdd.Top = 380;
            buttonAdd.BackColor = czerwony;
            buttonAdd.ForeColor = bialy;
            buttonAdd.TabStop = false;
            buttonAdd.Font = buttonFont;
            buttonAdd.FlatAppearance.BorderColor = transparent;
            buttonAdd.FlatAppearance.BorderSize = 0;

            textBoxAdd.Left = (this.ClientSize.Width - textBoxAdd.Width) / 2;
            textBoxAdd.Top = 270;

            labelAdd.Font = labelFont;
            labelAdd.ForeColor = czerwony;
            labelAdd.Left = textBoxAdd.Left - 5;
            labelAdd.Top = textBoxAdd.Top - 32;

            buttonAdd2.Left = (this.ClientSize.Width - buttonAdd2.Width) / 2;
            buttonAdd2.Top = 380;
            buttonAdd2.BackColor = czerwony;
            buttonAdd2.ForeColor = bialy;
            buttonAdd2.TabStop = false;
            buttonAdd2.Font = buttonFont;
            buttonAdd2.FlatAppearance.BorderColor = transparent;
            buttonAdd2.FlatAppearance.BorderSize = 0;

            labelAdd2.Width = 240;
            labelAdd2.Height = 80;
            labelAdd2.Top = 120;
            labelAdd2.Font = buttonFont;
            labelAdd2.ForeColor = czerwony;
            labelAdd2.AutoSize = false;
            labelAdd2.TextAlign = ContentAlignment.MiddleCenter;
            labelAdd2.Dock = DockStyle.None;
            labelAdd2.Left = (this.ClientSize.Width - labelAdd2.Width) / 2;

            buttonBack2.Left = 0;
            buttonBack2.Top = panel1.Bottom - 3;
            buttonBack2.BackColor = czerwony;
            buttonBack2.ForeColor = bialy;
            buttonBack2.TabStop = false;
            buttonBack2.Font = labelFont;
            buttonBack2.FlatAppearance.BorderColor = transparent;
            buttonBack2.FlatAppearance.BorderSize = 0;

            buttonBack3.Left = 0;
            buttonBack3.Top = panel1.Bottom - 3;
            buttonBack3.BackColor = czerwony;
            buttonBack3.ForeColor = bialy;
            buttonBack3.TabStop = false;
            buttonBack3.Font = labelFont;
            buttonBack3.FlatAppearance.BorderColor = transparent;
            buttonBack3.FlatAppearance.BorderSize = 0;

            panelContacts.Location = new Point(0, 130);
            panelContacts.AutoScroll = false;
            panelContacts.HorizontalScroll.Enabled = false;
            panelContacts.HorizontalScroll.Visible = false;
            panelContacts.HorizontalScroll.Maximum = 0;
            panelContacts.AutoScroll = true;

            panelMessages.Location = new Point(0, 110);
            panelMessages.AutoScroll = false;
            panelMessages.HorizontalScroll.Enabled = false;
            panelMessages.HorizontalScroll.Visible = false;
            panelMessages.HorizontalScroll.Maximum = 0;
            panelMessages.AutoScroll = true;

            buttonBack4.Left = 0;
            buttonBack4.Top = panel1.Bottom - 3;
            buttonBack4.BackColor = czerwony;
            buttonBack4.ForeColor = bialy;
            buttonBack4.TabStop = false;
            buttonBack4.Font = labelFont;
            buttonBack4.FlatAppearance.BorderColor = transparent;
            buttonBack4.FlatAppearance.BorderSize = 0;

            textBoxMessage.Location = new Point(panelMessages.Location.X, panelMessages.Location.Y + panelMessages.Height);
            textBoxMessage.Font = new Font("Calibri", 12);
            textBoxMessage.ForeColor = bialy;
            buttonSend.Location = new Point(textBoxMessage.Location.X + textBoxMessage.Width, textBoxMessage.Location.Y);
            buttonSend.BackColor = czerwony;
            buttonSend.ForeColor = bialy;
            buttonSend.Font = labelFont;
        }

        //przejœcie na ekran logowania
        private void buttonLogIn1_click(object sender, EventArgs e)
        {
            TurnOff(buttonLogIn1);
            TurnOff(buttonRegister1);
            TurnOn(labelLogIn);
            TurnOn(textBoxLogIn);
            TurnOn(labelRegister);
            TurnOn(textBoxPassword);
            TurnOn(buttonLogin2);
            TurnOn(buttonBack1);
        }

        //przejœcie na ekran rejestracji
        private void buttonRegister1_click(object sender, EventArgs e)
        {
            TurnOff(buttonLogIn1);
            TurnOff(buttonRegister1);
            TurnOn(labelLogIn);
            TurnOn(textBoxLogIn);
            TurnOn(labelRegister);
            TurnOn(textBoxPassword);
            TurnOn(buttonRegister2);
            TurnOn(buttonBack1);
        }

        //logowanie
        private void buttonLogIn2_click(object sender, EventArgs e)
        {
            if (!CheckTextBoxesForEmpty(textBoxLogIn, "You must enter your Username"))
                if (!CheckTextBoxesForFour(textBoxLogIn, "Your Username must contain at least 4 characters"))
                    if (!CheckTextBoxesForEmpty(textBoxPassword, "You must enter your password"))
                        if (!CheckTextBoxesForFour(textBoxPassword, "Your password must contain at least 4 characters"))
                        {
                            if (DBStuff.LogIn(textBoxLogIn.Text, textBoxPassword.Text))
                            {
                                uuser = textBoxLogIn.Text;
                                labelWelcome.Text += uuser;
                                ClearTextBoxes();
                                TurnOff(labelLogIn);
                                TurnOff(labelRegister);
                                TurnOff(textBoxLogIn);
                                TurnOff(textBoxPassword);
                                TurnOff(buttonRegister2);
                                TurnOff(buttonBack1);
                                TurnOff(buttonLogin2);
                                TurnOn(labelWelcome);
                                TurnOn(buttonContacts);
                                TurnOn(buttonAdd);

                                RabbitStuff.userName = uuser;
                                RabbitStuff.CreateConnection();
                                //zmiana napisu formularza, ¿eby wyœwietla³a zalogowanego u¿ytkownika dla ³atwiejszego testowania
                                this.Text += " - " + uuser; 
                            }
                            else
                                MessageBox.Show("Failed to log in");
                        }

        }

        //rejestracja
        private void buttonRegister2_click(object sender, EventArgs e)
        {
            if (!CheckTextBoxesForEmpty(textBoxLogIn, "You must enter your Username"))
                if (!CheckTextBoxesForFour(textBoxLogIn, "Your Username must contain at least 4 characters"))
                    if (!CheckTextBoxesForEmpty(textBoxPassword, "You must enter your password"))
                        if (!CheckTextBoxesForFour(textBoxPassword, "Your password must contain at least 4 characters"))
                        {
                            if (!DBStuff.LogIn(textBoxLogIn.Text, textBoxPassword.Text))
                            {
                                if (DBStuff.AddUser(textBoxLogIn.Text, textBoxPassword.Text))
                                {
                                    ClearTextBoxes();
                                    TurnOn(labelRegistered);
                                    TurnOn(buttonRegistered);
                                    TurnOff(labelLogIn);
                                    TurnOff(labelRegister);
                                    TurnOff(textBoxLogIn);
                                    TurnOff(textBoxPassword);
                                    TurnOff(buttonRegister2);
                                    TurnOff(buttonBack1);
                                }
                                else
                                {
                                    ClearTextBoxes();
                                }
                            }
                        }
        }


        //powrót do ekranu startowego z ekranu rejestracji albo logowania
        private void buttonBack1_click(object sender, EventArgs e)
        {
            TurnOn(buttonLogIn1);
            TurnOn(buttonRegister1);
            TurnOff(labelLogIn);
            TurnOff(textBoxLogIn);
            TurnOff(labelRegister);
            TurnOff(textBoxPassword);
            TurnOff(buttonLogin2);
            TurnOff(buttonRegister2);
            TurnOff(buttonBack1);
            ClearTextBoxes();
        }

        //powerót do ekranu startowego z ekranu pomyœlnej rejestracji
        private void buttonRegistered_Click(object sender, EventArgs e)
        {
            TurnOff(buttonRegistered);
            TurnOff(labelRegistered);
            TurnOn(buttonLogIn1);
            TurnOn(buttonRegister1);
        }

        //ekran dodawania kontaktów
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            TurnOff(buttonAdd);
            TurnOff(buttonContacts);
            TurnOff(labelWelcome);
            TurnOn(labelAdd);
            TurnOn(textBoxAdd);
            TurnOn(buttonAdd2);
            TurnOn(labelAdd2);
            TurnOn(buttonBack2);
        }

        //dodawanie u¿ytkownika do kontaktów
        private void buttonAdd2_Click(object sender, EventArgs e)
        {
            if (!CheckTextBoxesForEmpty(textBoxAdd, "You must enter the Username"))
                if (!CheckTextBoxesForFour(textBoxAdd, "The Username must contain at least 4 characters"))
                {
                    DBStuff.AddContact(uuser, textBoxAdd.Text);
                    textBoxAdd.Text = "";
                }
        }

        //cofanie siê do ekranu po zalogowaniu z ekranu dodawania kontaktów
        private void buttonBack2_Click(object sender, EventArgs e)
        {
            TurnOn(buttonAdd);
            TurnOn(buttonContacts);
            TurnOn(labelWelcome);
            TurnOff(labelAdd);
            TurnOff(textBoxAdd);
            TurnOff(buttonAdd2);
            TurnOff(labelAdd2);
            TurnOff(buttonBack2);
            ClearTextBoxes();
        }

        //cofanie siê do ekranu po zalogowaniu z ekranu kontaktów
        private void buttonBack3_Click(object sender, EventArgs e)
        {
            panelContacts.Controls.Clear();
            TurnOff(panelContacts);
            TurnOff(buttonBack3);
            TurnOn(buttonContacts);
            TurnOn(buttonAdd);
            TurnOn(labelWelcome);
        }

        //ekran kontaków
        private void buttonContacts_Click(object sender, EventArgs e)
        {
            TurnOn(buttonBack3);
            TurnOff(buttonContacts);
            TurnOff(buttonAdd);
            TurnOff(buttonBack2);
            TurnOff(labelWelcome);
            TurnOn(panelContacts);
            DBStuff.LoadContacts(uuser, panelContacts);
        }

        //cofanie siê z widoku wiadomoœci do kontaktów
        private void buttonBack4_Click(object sender, EventArgs e)
        {
            TurnOff(panelMessages);
            TurnOn(panelContacts);
            TurnOff(buttonBack4);
            TurnOn(buttonBack3);
            TurnOff(textBoxMessage);
            TurnOff(buttonSend);
            ClearTextBoxes();
            panelMessages.Controls.Clear();
            RabbitStuff.CloseConnection();
        }

        //wysy³anie wiadomoœci
        private void buttonSend_Click(object sender, EventArgs e)
        {
            string s = textBoxMessage.Text;
            if (string.IsNullOrEmpty(s))
                return;
            else
            {
                DBStuff.SaveMessage(uuser, uuser2, s);
                panelMessages.Refresh();
                textBoxMessage.Text = "";                
            }                
        }

        //w³¹czanie kontrolek
        public static void TurnOff(Control C)
        {
            C.Visible = false;
            C.Enabled = false;
        }

        //wy³¹czanie kontrolek
        public static void TurnOn(Control C)
        {
            C.Visible = true;
            C.Enabled = true;
        }

        //czyszczenie textboxów (przy cofaniu siê do ekranu startowego)
        private void ClearTextBoxes()
        {
            textBoxLogIn.Text = "";
            textBoxPassword.Text = "";
            textBoxAdd.Text = "";
            textBoxMessage.Text = "";
        }

        //sprawdzenie, czy textbox jest pusty
        private bool CheckTextBoxesForEmpty(TextBox textbox, string message)
        {
            if (textbox.Text.Length == 0)
            {
                MessageBox.Show(message);
                return true;
            }
            else
                return false;
        }

        //sprawdzenie, czy textbox ma przynajmniej 4 znaki
        private bool CheckTextBoxesForFour(TextBox textbox, string message)
        {
            if (textbox.Text.Length < 4)
            {
                MessageBox.Show(message);
                return true;
            }
            else return false;
        }

        //wywo³anie przycisku wys³ania wiadomoœci, je¿eli przy wpisywaniu wiadomoœci zostanie wciœniêty Enter
        //chyba ¿e bêdzie to Enter+Shift; wtedy textbox doda now¹ linijkê
        private void textBoxMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(!e.Shift)
                {
                    {
                        e.SuppressKeyPress = true;
                        buttonSend_Click(sender, e);
                    }
                }
            }
        }

        //wywo³anie przycisku zalogowania albo rejestracji przy wciœniêciu Entera podczas wpisywania nazwy u¿ytkownika
        private void textBoxLogIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (buttonLogin2.Enabled)
                    buttonLogIn2_click(sender, e);
                else
                    if (buttonRegister2.Enabled)
                    buttonRegister2_click(sender, e);
            }            
        }

        //wywo³anie przycisku zalogowania albo rejestracji przy wciœniêciu Entera podczas wpisywania has³a
        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (buttonLogin2.Enabled)
                    buttonLogIn2_click(sender, e);
                else
                    if (buttonRegister2.Enabled)
                    buttonRegister2_click(sender, e);
            }
        }

        //wywo³anie przycisku dodawania kontaktu przy wciœniêciu Enter podczas wpisywania nazwy u¿ytkownika
        private void textBoxAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonAdd2_Click(sender, e);
        }
    }
}