using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2Tereksay
{
    public partial class Company : Form
    {
        public Company()
        {
            InitializeComponent();
        }

        private void label4_MouseClick(object sender, MouseEventArgs e)
        {
            
            string url = "https://daniel.kg/o-kompanii/";
            Process.Start(url);
        }

        private void Company_Load(object sender, EventArgs e)
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

        private void Company_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;


            Form1 menu = new Form1();
            menu.Show();

            this.Hide();
        }
    }
}