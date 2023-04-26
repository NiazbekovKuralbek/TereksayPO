using System;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Drawing;

namespace WindowsFormsApp2Tereksay
{
    public partial class Employe : Form
    {
        public Employe()
        {
            InitializeComponent();
        }

        private void Employe_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Mebel mebel = new Mebel();
            mebel.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Material material = new Material();
            material.Show();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Modules modules = new Modules();
            modules.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Postman postman = new Postman();
            postman.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Finish_product finishProduct = new Finish_product();
            finishProduct.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Sales_product salesProduct = new Sales_product();
            salesProduct.Show();
        }

        private void Employe_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;


            Form1 menu = new Form1();
            menu.Show();

            this.Hide();
        }
    }
}