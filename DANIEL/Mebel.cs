using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2Tereksay
{
    public partial class Mebel : Form
    {
        
        private DataBase dataBase = new DataBase();
        private DataTable Table, Table1 = null;
        private SqlDataAdapter adapter, adapter1 = null;
        public Mebel()
        {
            InitializeComponent();
        }

        private void Mebel_Load(object sender, EventArgs e)
        {
            dataBase.openConnection();
            string query = "SELECT Name, Amount, Cost_selling FROM Product";
            adapter = new SqlDataAdapter( query, dataBase.getConnection());
            Table = new DataTable();
            adapter.Fill(Table);
            dataGridView1.DataSource = Table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text ==
                "" & textBox2.Text == "" & textBox3.Text == "")
            {
                MessageBox.Show("Данные не введены");
            }
            else
            {
                try
                {
                    dataBase.openConnection();
                    
                    string quary = "INSERT INTO Product (Name, Amount, Cost_selling) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                    SqlCommand cmd = new SqlCommand(quary, dataBase.getConnection());
                    cmd.ExecuteNonQuery();
                    Table.Clear();
                    adapter.Fill(Table);
                    dataGridView1.DataSource = Table;
                    textBox3.Text = "";
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    throw;
                }
                finally
                {
                    dataBase.closeConnection();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            DialogResult result = MessageBox.Show("Удалить?", "Удаление",  MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                if (textBox1.Text ==
                    "" & textBox2.Text == "" & textBox3.Text == "")
                {
                    MessageBox.Show("Данные не выбраны");
                }
                else
                {
                    try
                    {
                        dataBase.openConnection();
                        string quary = "DELETE FROM Product WHERE Name ='" + textBox1.Text + "';";

                        SqlCommand cmd = new SqlCommand(quary, dataBase.getConnection());
                        cmd.ExecuteNonQuery();
                        Table.Clear();
                        adapter.Fill(Table);
                        dataGridView1.DataSource = Table;
                        textBox3.Text = "";
                        textBox1.Text = "";
                        textBox2.Text = "";
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception);
                        throw;
                    }
                    finally
                    {
                        dataBase.closeConnection();
                    }
                }
            }
            else 
            {
                
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text ==
                "" & textBox2.Text == "" & textBox3.Text == "")
            {
                MessageBox.Show("Данные не выбраны");
            }
            else
            {
                try
                {
                    dataBase.openConnection();
                    string quary = "UPDATE Product SET Name = '" + textBox1.Text + "',Amount='" + textBox2.Text + "',Cost_selling='" + textBox3.Text + "' WHERE Name='" + textBox1.Text + "';";
                    SqlCommand cmd = new SqlCommand(quary, dataBase.getConnection());
                    cmd.ExecuteNonQuery();
                    Table.Clear();
                    adapter.Fill(Table);
                    dataGridView1.DataSource = Table;
                    textBox3.Text = "";
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    throw;
                }
                finally
                {   
                    dataBase.closeConnection();
                }
            }
        }
    }
}