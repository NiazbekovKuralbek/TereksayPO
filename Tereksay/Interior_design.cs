using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApp2Tereksay
{
    public partial class Interior_design : Form
    {
        public Interior_design()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string phoneNumber = "996778581125";
            string url = "https://api.whatsapp.com/send?phone=" + phoneNumber;
            Process.Start(url);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string phoneNumber = "996778581125";
            string url = "https://api.whatsapp.com/send?phone=" + phoneNumber;
            Process.Start(url);
        }

        private void label4_MouseClick(object sender, MouseEventArgs e)
        {
            
            string url = "https://daniel.kg/service/dizajn-interera/";
            Process.Start(url);
        }
    }
}