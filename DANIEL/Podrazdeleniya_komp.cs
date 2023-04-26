using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2Tereksay
{
    public partial class Podrazdeleniya_komp : Form
    {
        public Podrazdeleniya_komp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kitchen_fur kitchenFur = new Kitchen_fur();
            kitchenFur.Show();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Kitchen_fur kitchenFur = new Kitchen_fur();
            kitchenFur.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Business_fur businessFur = new Business_fur();
            businessFur.Show();
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            Business_fur businessFur = new Business_fur();
            businessFur.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Living_fur livingFur = new Living_fur();
            livingFur.Show();
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            Living_fur livingFur = new Living_fur();
            livingFur.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Custom_hall customHall = new Custom_hall();
            customHall.Show();
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            Custom_hall customHall = new Custom_hall();
            customHall.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Closets closets = new Closets();
            closets.Show();
        }

        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            Closets closets = new Closets();
            closets.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Interior_design interiorDesign = new Interior_design();
            interiorDesign.Show();
        }

        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {
            Interior_design interiorDesign = new Interior_design();
            interiorDesign.Show();
        }

        private void Podrazdeleniya_komp_Load(object sender, EventArgs e)
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

        private void Podrazdeleniya_komp_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;


            Form1 menu = new Form1();
            menu.Show();

            this.Hide();
        }
    }
}