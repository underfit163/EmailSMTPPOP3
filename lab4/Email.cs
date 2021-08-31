using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

namespace lab4
{
    //класс для отправлки сообщения
    class Email
    {
        //recipient - получатель сообщения,
        //smtpServer - используемый SMTP сервер,
        //from - отправитель сообщения, 
        //password - пароль от ящика отправителя, 
        //caption - тема сообщения,
        //message - текст письма, 
        //files - прикрепляемые к письму файлы

        public static void sendingMessage(string recipient, string smtpServer, string from, string password, string caption, string message, List<string> files, int port)
        {
            try
            {
                //вызываем конструктор с параметрами для переменной mail (создаем письмо)
                var mail = new MailMessage(from, recipient, caption, message);

                //пока количество прикрепляемых файлов не равно нулю, добавляем их к письму с помощью Attachments.Add
                if (files.Count > 0)
                {
                    for (int i = 0; i < files.Count; i++)
                    {
                        mail.Attachments.Add(new Attachment(files[i]));
                    }
                }

                //создаем smtp клиент (smtpServer - сервер, который ты указываешь в форме, 587 - порт)
                SmtpClient client = new SmtpClient(smtpServer, port);
                client.EnableSsl = true;

                //здесь указываем логин и пароль отправителя
                client.Credentials = new NetworkCredential(from.Split('@')[0], password);

                //здесь указывается способ отправки сообщения - по сети на сервер smtp
                client.DeliveryMethod = SmtpDeliveryMethod.Network;

                //собственно, отправляем сообщение
                client.Send(mail);

                MessageBox.Show("Письмо успешно отправлено по адресу:\n" + recipient);
            }
            catch (Exception e)
            {
                throw new Exception("Mail.Send: " + e.Message);
            }
        }
    }
}
