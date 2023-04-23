using System.Diagnostics;
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
    }
}