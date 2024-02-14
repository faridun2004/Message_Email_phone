using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace BON_Kori5_Message_Dastai_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string to = textBox1.Text;
                string subject=textBox2.Text;
                string body=textBox3.Text;

                string Email = "faridun11110001@gmail.com";
                string Password = "faridun040504";
                string Host = "smtp.gmail.com";
                int port = 587;

                using(MailMessage mail =new MailMessage(Email,to , subject,body))
                
                {
                    using(SmtpClient smtp = new SmtpClient(Host,port))
                    {
                        smtp.UseDefaultCredentials = false;
                        smtp.EnableSsl = true;
                        smtp.Credentials=new NetworkCredential(Email, Password);
                        smtp.Send(mail);
                        MessageBox.Show("Email sent successfully!", "success");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"{ex} Error");
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
