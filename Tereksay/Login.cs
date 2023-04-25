using System;
using System.Drawing;
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
            if (textBox1.Text == "" & textBox2.Text == "" )
            {
                textBox1.Text = "";
                textBox2.Text = "";
                Form1 menu = new Form1();
                menu.Show();
                
            }
            else
            {
                MessageBox.Show("Неверный пароль или логин");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Получаем размер экрана
            Rectangle screenBounds = Screen.PrimaryScreen.Bounds;

            // Вычисляем координаты для центрирования окна
            int x = (screenBounds.Width - this.ClientSize.Width) / 2;
            int y = (screenBounds.Height - this.ClientSize.Height) / 2;

            // Устанавливаем координаты для отображения окна
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(x, y);
        }
    }
}