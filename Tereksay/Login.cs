using System;
using System.Windows.Forms;

namespace WindowsFormsApp2Tereksay
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Bekzhan" & textBox2.Text == "12345" )
            {
                Form1 menu = new Form1();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Неверный пароль или логин");
            }
        }
    }
}