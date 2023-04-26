using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2Tereksay
{
    public partial class Founders : Form
    {
        public Founders()
        {
            InitializeComponent();
        }

        private void label6_MouseClick(object sender, MouseEventArgs e)
        {
            string url = "https://bosettimarella.it/en/chi-siamo";
            Process.Start(url);
        }

        private void label7_MouseClick(object sender, MouseEventArgs e)
        {
            string url = "https://www.decor-profi.net/";
            Process.Start(url);
        }

        private void label8_MouseClick(object sender, MouseEventArgs e)
        {
            string url = "https://daniel.kg/#:~:text=next-,%D0%9F%D0%90%D0%A0%D0%A2%D0%9D%D0%95%D0%A0%D0%AB,-prev";
            Process.Start(url);
        }

        private void Founders_Load(object sender, EventArgs e)
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

        private void Founders_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;


            Form1 menu = new Form1();
            menu.Show();

            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }
    }
}