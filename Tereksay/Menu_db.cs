using System;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
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
    }
}