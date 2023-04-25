using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2Tereksay
{
    public partial class Contacts : Form
    {
        public Contacts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "https://daniel.kg/kontakty/#:~:text=%D0%B4%D0%BE%2018%3A00-,%D0%A1%D0%B2%D1%8F%D0%B6%D0%B8%D1%82%D0%B5%D1%81%D1%8C%20%D1%81%20%D0%BD%D0%B0%D0%BC%D0%B8,-%D0%9E%D0%A2%D0%9F%D0%A0%D0%90%D0%92%D0%98%D0%A2%D0%AC";
            Process.Start(url);
        }

        private void label4_MouseClick(object sender, MouseEventArgs e)
        {
            string url = "https://daniel.kg/kontakty/";
            Process.Start(url);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            string url = "https://www.facebook.com/danielmebelB/";
            Process.Start(url);
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            string url = "https://www.instagram.com/danielmebel/";
            Process.Start(url);
        }

        private void Contacts_Load(object sender, EventArgs e)
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

        private void Contacts_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;


            Form1 menu = new Form1();
            menu.Show();

            this.Hide();
        }
    }
}