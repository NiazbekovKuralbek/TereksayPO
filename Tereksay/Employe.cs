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
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\RiderProjects\TereksayPO\Daniel.accdb;Persist Security Info=False;";
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM Employe";
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Employe");

            dataGridView1.DataSource = dataSet.Tables["Employe"];
            

            connection.Close();
        }
    }
}