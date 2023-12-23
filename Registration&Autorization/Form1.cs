using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration_Autorization
{
    public partial class Form1 : Form
    {
        int Success = 1;
        int attempts = 3;
        string Pass;
            string Login;
        TcpClient Client = new TcpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             Login = textBox1.Text;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client.Connect("127.0.0.1", 8888);
            NetworkStream stream = Client.GetStream();
            
            MessageBox.Show(Client.Connected.ToString());
            stream.Write(Encoding.UTF8.GetBytes(Login),0,Login.Length);
            if (Pass == "123" & Login == "123")
            {
                Success = 0;
                label4.Text = "Success";
                MessageBox.Show("Success");
            }
           
            else if (attempts > 1 & Success==1)
            {
                attempts--;
                label4.Text = $"attempts count - {attempts}";
            }
           else
            {

                label4.Text = "attempts is out";
                label4.ForeColor = Color.Red;
            }
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            Pass = textBox2.Text;
            
        }
    }
}
