namespace networklb4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.send_e_mail = new System.Windows.Forms.Button();
            this.smtp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fromsender = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tema = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.add_file = new System.Windows.Forms.Button();
            this.add_adresat = new System.Windows.Forms.Button();
            this.adresat = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mailcount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nummail = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // send_e_mail
            // 
            this.send_e_mail.Location = new System.Drawing.Point(362, 267);
            this.send_e_mail.Name = "send_e_mail";
            this.send_e_mail.Size = new System.Drawing.Size(328, 23);
            this.send_e_mail.TabIndex = 0;
            this.send_e_mail.Text = "Отправить";
            this.send_e_mail.UseVisualStyleBackColor = true;
            this.send_e_mail.Click += new System.EventHandler(this.button1_Click);
            // 
            // smtp
            // 
            this.smtp.Location = new System.Drawing.Point(153, 16);
            this.smtp.Name = "smtp";
            this.smtp.Size = new System.Drawing.Size(194, 20);
            this.smtp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "SMTP сервер:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "E-mail адрес получателя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "E-mail адрес отправителя:";
            // 
            // fromsender
            // 
            this.fromsender.Location = new System.Drawing.Point(153, 44);
            this.fromsender.Name = "fromsender";
            this.fromsender.Size = new System.Drawing.Size(194, 20);
            this.fromsender.TabIndex = 6;
            this.fromsender.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Пароль:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Тема:";
            // 
            // tema
            // 
            this.tema.Location = new System.Drawing.Point(153, 106);
            this.tema.Name = "tema";
            this.tema.Size = new System.Drawing.Size(194, 20);
            this.tema.TabIndex = 10;
            this.tema.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(15, 147);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(332, 143);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(153, 75);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(194, 20);
            this.pass.TabIndex = 13;
            // 
            // add_file
            // 
            this.add_file.Location = new System.Drawing.Point(362, 163);
            this.add_file.Name = "add_file";
            this.add_file.Size = new System.Drawing.Size(153, 23);
            this.add_file.TabIndex = 14;
            this.add_file.Text = "Прикрепить файл";
            this.add_file.UseVisualStyleBackColor = true;
            this.add_file.Click += new System.EventHandler(this.button2_Click);
            // 
            // add_adresat
            // 
            this.add_adresat.Location = new System.Drawing.Point(496, 42);
            this.add_adresat.Name = "add_adresat";
            this.add_adresat.Size = new System.Drawing.Size(194, 20);
            this.add_adresat.TabIndex = 15;
            this.add_adresat.Text = "Добавить адрес";
            this.add_adresat.UseVisualStyleBackColor = true;
            this.add_adresat.Click += new System.EventHandler(this.button3_Click);
            // 
            // adresat
            // 
            this.adresat.Location = new System.Drawing.Point(496, 16);
            this.adresat.Name = "adresat";
            this.adresat.Size = new System.Drawing.Size(194, 20);
            this.adresat.TabIndex = 16;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(362, 71);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(328, 56);
            this.listBox1.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Прикрепленные файлы:";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(362, 192);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(328, 69);
            this.listBox2.TabIndex = 19;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(15, 336);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(675, 59);
            this.richTextBox2.TabIndex = 20;
            this.richTextBox2.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(481, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Просмотреть письмо";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Писем доступно:";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // mailcount
            // 
            this.mailcount.Location = new System.Drawing.Point(128, 310);
            this.mailcount.Name = "mailcount";
            this.mailcount.Size = new System.Drawing.Size(100, 20);
            this.mailcount.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "№ письма:";
            // 
            // nummail
            // 
            this.nummail.Location = new System.Drawing.Point(429, 307);
            this.nummail.Name = "nummail";
            this.nummail.Size = new System.Drawing.Size(35, 20);
            this.nummail.TabIndex = 25;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(564, 401);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 20);
            this.button3.TabIndex = 26;
            this.button3.Text = "Скачать вложения";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 433);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.nummail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mailcount);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.adresat);
            this.Controls.Add(this.add_adresat);
            this.Controls.Add(this.add_file);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.tema);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fromsender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.smtp);
            this.Controls.Add(this.send_e_mail);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button send_e_mail;
        private System.Windows.Forms.TextBox smtp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fromsender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tema;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button add_file;
        private System.Windows.Forms.Button add_adresat;
        private System.Windows.Forms.TextBox adresat;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox mailcount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nummail;
        private System.Windows.Forms.Button button3;
    }
}

