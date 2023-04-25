using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2Tereksay
{
    public partial class Price_deadlines : Form
    {
        public Price_deadlines()
        {
            InitializeComponent();
        }

        private void label9_MouseClick(object sender, MouseEventArgs e)
        {
            
            string url = "https://daniel.kg/ceny-i-sroki/";
            Process.Start(url);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string phoneNumber = "996778581125";
            string url = "https://api.whatsapp.com/send?phone=" + phoneNumber;
            Process.Start(url);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void Price_deadlines_Load(object sender, EventArgs e)
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

        private void Price_deadlines_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;


            Form1 menu = new Form1();
            menu.Show();

            this.Hide();
        }
    }
}