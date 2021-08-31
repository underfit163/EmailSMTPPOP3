using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace networklb4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            smtp.Text = "smtp.yandex.ru";
            fromsender.Text = "polya.glotova@yandex.ru";
            pass.Text = "01av1998TIGRICA";
            tema.Text = "tteeмa";
            richTextBox1.Text = "text pismaaa";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        List<string> attFile = new List<string>();
        List<string> mailTo = new List<string>();


        private void button1_Click(object sender, EventArgs e)
        {

            string smtpServer = smtp.Text;
            string from = fromsender.Text;
            string password = pass.Text;
            
            string caption = tema.Text;
            string message = richTextBox1.Text;
            for (int i = 0; i < mailTo.Count; i++)
            {
                SendEMail.SendMail(smtpServer, from, password, mailTo[i], caption, message, attFile);
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

  

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName != "")
            {
                attFile.Add(ofd.FileName);
                listBox2.Items.Add(ofd.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mailTo.Add(adresat.Text);
            listBox1.Items.Add(adresat.Text);
            adresat.Clear();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Pop3Lib.Client client = new Pop3Lib.Client("pop.yandex.ru", "polya.glotova@yandex.ru", "01av1998TIGRICA");
            mailcount.Text = client.MessageCount.ToString();
            client.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int n = int.Parse(nummail.Text);
            Pop3Lib.Client client = new Pop3Lib.Client("pop.yandex.ru", "polya.glotova@yandex.ru", "01av1998TIGRICA");
            Pop3Lib.MailItem m=null;
            for (int i = 1; i <= n; i++) client.NextMail(out m);
            richTextBox2.Text += m.From + m.GetText();
            client.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String server = textBox6.Text;
            String username = textBox7.Text;
            String pass = textBox8.Text;
            String tema = textBox9.Text;
            // Используем using чтобы соединение автоматически закрывалось 
            using (client = new Pop3Client())
            {
                // Подключение к серверу 
                client.Connect(server, 995, true);

                // Аутентификация (проверка логина и пароля) 
                client.Authenticate(username, pass, AuthenticationMethod.UsernameAndPassword);

                if (client.Connected)
                {
                    // Получение количества сообщений в почтовом ящике 
                    messageCount = client.GetMessageCount();

                    // Выделяем память под список сообщений. Мы хотим получить все сообщения 
                    allMessages = new List<OpenPop.Mime.Message>(messageCount);

                    // Сообщения нумеруются от 1 до messageCount включительно 
                    // Другим языком нумерация начинается с единицы 
                    // Большинство серверов присваивают новым сообщениям наибольший номер (чем меньше номер тем старее сообщение) 
                    // Т.к. цикл начинается с messageCount, то последние сообщения должны попасть в начало списка 
                    for (int i = messageCount; i > 0; i--)
                    {
                        allMessages.Add(client.GetMessage(i));

                        OpenPop.Mime.Message message = client.GetMessage(i);

                        string subject = message.Headers.Subject; //заголовок 
                        if (subject == textBox4.Text)
                        {
                            string date = message.Headers.Date.ToString(); //Дата/Время 
                            string from = message.Headers.From.ToString(); //от кого 
                            string body = "";

                            // ищем первую плейнтекст версию в сообщении 
                            MessagePart mpPlain = message.FindFirstPlainTextVersion();

                            if (mpPlain != null)
                            {
                                Encoding enc = mpPlain.BodyEncoding;
                                body = enc.GetString(mpPlain.Body); //получаем текст сообщения 

                            }

                            ListViewItem mes = new ListViewItem(new string[] { subject, date, from, body });

                            listView1.Items.Add(mes);
                            listView1.Items.Add(date);
                            listView1.Items.Add(from);
                            listView1.Items.Add(body);
                        }
                    }


                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            save(messageCount, allMessages);

        }
        public void save(int messageCount, List<OpenPop.Mime.Message> allMessages)
        {
            ////Ищем во всех письмах все вложения 
            for (int i = 0; i < messageCount; i++)
            {
                OpenPop.Mime.Message msg = allMessages[i];
                var att = msg.FindAllAttachments();
                if (att != null)
                {
                    MessageBox.Show("В файле есть вложения,они сохранены на рабочем столе!");
                }
                foreach (var ado in att)
                {

                    ado.Save(new System.IO.FileInfo(System.IO.Path.Combine("C://Users//Кристина//Desktop", ado.FileName)));
                }

            }
        }


        private void button3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
