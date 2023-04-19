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
    public partial class Production : Form
    {
        public Production()
        {
            InitializeComponent();
        }

        private void ReserveInfoButton_Click(object sender, EventArgs e)
        {
            FactoryForm form = new FactoryForm();
            form.Show();

        }

        private void MiningInfoButton_Click(object sender, EventArgs e)
        {
            MiningForm form = new MiningForm();   
            form.Show();
        }

        private void FactoryInfobutton_Click(object sender, EventArgs e)
        {
            StockForm form = new StockForm();   
            form.Show();
        }
    }
}
