using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace RabidMQ
{
    class RabbitStuff
    {

        public static IConnection _connection;
        public static IModel _channel;
        public static string userName;
        public static string userName2;
        public static EventingBasicConsumer consumer;
        static bool sending = false;

        public static IModel CreateConnection()
        {
            ConnectionFactory connectionFactory = new ConnectionFactory()
            {
                HostName = "localhost"
            };
            _connection = connectionFactory.CreateConnection();
            return _connection.CreateModel();
        }

        //deklarowanie wymiany
        public static void DeclareExchange(string exchangeName)
        {
            _channel = _connection.CreateModel();
            _channel.ExchangeDeclare(exchangeName, ExchangeType.Fanout, false, false);
        }

        //deklarowanie kolejki
        public static void DeclareQueue(string queueName)
        {
            _channel = _connection.CreateModel();
            _channel.QueueDeclare(queueName, false, false, false);
        }

        //"dołączenie" kolejki do wymiany
        public static void BindQueue(string exchangeName, string queueName)
        {
            _channel = _connection.CreateModel();
            _channel.QueueBind(queueName, exchangeName, "");
        }

        //wysłanie wiadomości
        public static void SendMessage(string message, string receiver, string exchangeName)
        {
            _channel = _connection.CreateModel();
            _channel.BasicPublish(exchangeName, userName, null, Encoding.UTF8.GetBytes(message));
            sending = true;
            PurgeQueue(userName + "-" + userName2 + "-queue");
            PurgeQueue(userName2 + "-" + userName + "-queue");
        }

        //otrzymanie wiadomości i wyświetlenie jej na panelu z wiadomościami
        public static void ReceiveMessage(object sender, BasicDeliverEventArgs e)
        {
            Panel panelMessages = Application.OpenForms["Form1"].Controls["panelMessages"] as Panel;
            Color kolor = new Color();
            string person;
            if (sending)
            {
                kolor = Form1.niebieski;
                person = "You";
            }
            else
            {
                kolor = Form1.czerwony;
                person = userName2;
            }
            string message = Encoding.UTF8.GetString(e.Body.ToArray());
            panelMessages.Invoke(new Action(delegate ()
            {
                panelMessages.VerticalScroll.Value = panelMessages.VerticalScroll.Maximum;
                int y = 0;
                int x = 10;
                int i = 0;
                foreach (Control control in panelMessages.Controls)
                {
                    if(control.Location.Y + control.Height + 16 > y)
                        y = control.Location.Y + control.Height + 16;
                }
                if (y > panelMessages.Height)
                    y = panelMessages.Height + 8;
                Label label = new Label();
                label.Location = new Point(x, y);
                label.Name = "label" + i;
                label.Text = person + ":";
                label.Font = new Font("Calibri", 12);
                label.ForeColor = kolor;
                label.AutoSize = true;
                label.MaximumSize = new Size(70, 200);
                panelMessages.Controls.Add(label);

                Label label2 = new Label();
                label2.Location = new Point(80, y);
                label2.Name = "label2" + i;
                label2.Font = new Font("Calibri", 12);
                label2.ForeColor = kolor;
                label2.AutoSize = true;
                label2.MaximumSize = new Size(320 - label2.Width, 200);
                label2.Text = message;
                panelMessages.Controls.Add(label2);
                panelMessages.VerticalScroll.Value = panelMessages.VerticalScroll.Maximum;
                if (label.Height > label2.Height)
                    y += label.Height;
                else
                    y += label2.Height;
                sending = false;
            }));
        }

        //otrzymywanie wiadomości
        public static void Subscribe(string queueName)
        {
            _channel = _connection.CreateModel();
            consumer = new EventingBasicConsumer(_channel);
            consumer.Received += ReceiveMessage;
            _channel.BasicConsume(queueName, true, consumer);
        }

        //to jest po to, żeby nie zostawały wiadomości w kolejce w Queue->Unacked
        //wysyłają się, a nie ma czegoś takiego, że przy załadowaniu ładują się i z bazy i z kolejki
        public static void PurgeQueue(string queuename)
        {
            _channel = _connection.CreateModel();
            DeclareQueue(queuename); //deklarujemy kolejkę na wszelki wypadek, gdyby nie istniała
            _channel.QueuePurge(queuename);
        }

        //zamyka połączenie przy wyjściu z konwersacji
        //to się przydaje w takim scenariuszu, gdy np. są 3 okna:
        //osoba 1 rozmawia z osobą 2
        //osoba 2 wyjdzie z okna rozmowy z osobą 1 i zacznie rozmawiać z osobą 3
        //bez tej metody osoba 2 otrzymywałaby komunikaty od osoby 1 pomimo otwarcia okna rozmowy z osobą 3
        public static void CloseConnection()
        {
            _connection.Close();
        }
    }
}
