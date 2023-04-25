using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2Tereksay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Company company = new Company();
            company.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Podrazdeleniya_komp podrazdeleniyaKomp = new Podrazdeleniya_komp();
            podrazdeleniyaKomp.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Founders founders = new Founders();
            founders.Show();
            this.Close();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Company company = new Company();
            company.Show();
            this.Close();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Contacts contacts = new Contacts();
            contacts.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Price_deadlines priceDeadlines = new Price_deadlines();
            priceDeadlines.Show();
            this.Close();
        }

        private void учредителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Podrazdeleniya_komp podrazdeleniyaKomp = new Podrazdeleniya_komp();
            podrazdeleniyaKomp.Show();
            this.Close();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Company company = new Company();
            company.Show();
            this.Close();
        }

        private void производствоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Founders founders = new Founders();
            founders.Show();
            this.Close();
        }

        private void социальнаяОтветственностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Price_deadlines priceDeadlines = new Price_deadlines();
            priceDeadlines.Show();
            this.Close();
        }


        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void контактыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contacts contacts = new Contacts();
            contacts.Show();
            this.Close();
        }

        private void сотрудникиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Employe employe = new Employe();
            employe.Show();
            this.Close();
        }

        private void оРазработчикеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Developer developer = new Developer();
            developer.Show();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
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