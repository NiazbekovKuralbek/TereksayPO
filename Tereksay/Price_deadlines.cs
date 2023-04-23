using System;
using System.Diagnostics;
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
    }
}