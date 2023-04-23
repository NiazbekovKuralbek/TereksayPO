using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApp2Tereksay
{
    public partial class Founders : Form
    {
        public Founders()
        {
            InitializeComponent();
        }

        private void label6_MouseClick(object sender, MouseEventArgs e)
        {
            string url = "https://bosettimarella.it/en/chi-siamo";
            Process.Start(url);
        }

        private void label7_MouseClick(object sender, MouseEventArgs e)
        {
            string url = "https://www.decor-profi.net/";
            Process.Start(url);
        }

        private void label8_MouseClick(object sender, MouseEventArgs e)
        {
            string url = "https://daniel.kg/#:~:text=next-,%D0%9F%D0%90%D0%A0%D0%A2%D0%9D%D0%95%D0%A0%D0%AB,-prev";
            Process.Start(url);
        }
    }
}