using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
namespace networklb4

{

    class SendEMail
    {

        public static void SendMail(string smtpServer, string from, string password,string mailto, string caption, string message, List<string> attachFile)
        {
            SmtpClient client = null;
            try
            {
                var msg = new MailMessage(from, mailto, caption, message);
                
                if (attachFile.Count!=0)
                {
                    for (int i = 0; i < attachFile.Count; i++)
                    {
                        msg.Attachments.Add(new Attachment(attachFile[i]));
                    }
                }
                client = new SmtpClient(smtpServer, 25);
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(from.Split('@')[0], password);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(msg);
                MessageBox.Show("Письмо отправлено по адресу: "+mailto);
        }
            catch (Exception e)
            {
                MessageBox.Show("Mail.Send: " + e.Message);
            }
            //finally
            //{
            //    client.Dispose();
            //}
        }
    }
}
