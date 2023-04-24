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
    }
}