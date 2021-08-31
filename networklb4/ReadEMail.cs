using Limilabs.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace networklb4
{
    class ReadEMail
    {
        public static void ReadMail()
        {
            OpenPop.Pop3.Pop3Client PopClient = new OpenPop.Pop3.Pop3Client();
            PopClient.Connect("pop.rambler.ru", 995, true);
            PopClient.Authenticate("username", "pass", OpenPop.Pop3.AuthenticationMethod.UsernameAndPassword);
            MailBuilder builder = new MailBuilder();
            for (int i=0; i< PopClient.GetMessageCount(); i++)
            {

                OpenPop.Mime.Message email = PopClient.GetMessage(i);
                //*******************
                Console.WriteLine(email.FindAllTextVersions()[i].ToString());
                Console.WriteLine(email.Text);
            }
            pop3.Close();
        }
    }
}
