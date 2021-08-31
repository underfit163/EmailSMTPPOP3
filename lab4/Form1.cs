using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> recipients = new List<string>(); 
        List<string> files = new List<string>(); 

        private void button3_Click(object sender, EventArgs e) 
        {
            string message = richTextBox1.Text; 
            string smtpServer = textBox1.Text; 
            string from = textBox3.Text; 
            string password = textBox4.Text; 
            string caption = textBox5.Text;
            int port = Convert.ToInt32(textBox6.Text);
            SmtpClient client = new SmtpClient(smtpServer, port);
            client.Credentials = new System.Net.NetworkCredential(from, password);
        
            for (int i = 0; i < recipients.Count; i++)
            {
                Email.sendingMessage(recipients[i], smtpServer, from, password, caption, message, files, port);
            }
        }

        private void button2_Click(object sender, EventArgs e) 
        {
            OpenFileDialog fileDialog = new OpenFileDialog(); 
            
            if (fileDialog.ShowDialog() == DialogResult.OK && fileDialog.FileName != "")
            {                
                files.Add(fileDialog.FileName);                
                listBox2.Items.Add(fileDialog.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e) 
        {            
            recipients.Add(textBox2.Text);
            listBox1.Items.Add(textBox2.Text); 
            textBox2.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
