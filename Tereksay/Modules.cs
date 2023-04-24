using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2Tereksay
{
    public partial class Modules : Form
    {
        public Modules()
        {
            InitializeComponent();
        }
        private DataBase dataBase = new DataBase();
        private DataTable Table, Table1 = null;
        private SqlDataAdapter adapter, adapter1 = null;
        private void Modules_Load(object sender, EventArgs e)
        {
            dataBase.openConnection();
            string query = "SELECT Modules.ID, Product.Name, Materials.Name AS Expr1, Modules.Amount FROM Modules INNER JOIN Product ON Modules.Product = Product.ID INNER JOIN Materials ON Modules.Materials = Materials.ID";
            adapter = new SqlDataAdapter( query, dataBase.getConnection());
            Table = new DataTable();
            adapter.Fill(Table);
            dataGridView1.DataSource = Table;
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["ID"].ReadOnly = true;
            Load_combobox();
            textBox1.Visible = false;

        }

        private void Load_combobox()
        {
            string sql = "SELECT * FROM Product";
            using (SqlCommand cmd = new SqlCommand(sql, dataBase.getConnection()))
            {
                cmd.CommandType = CommandType.Text;
                Table1 = new DataTable();
                adapter1 = new SqlDataAdapter(cmd);
                adapter1.Fill(Table1);
                comboBox1.DataSource = Table1;
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "ID";

            }
            string sql1 = "SELECT * FROM Materials";
            using (SqlCommand cmd = new SqlCommand(sql1, dataBase.getConnection()))
            {
                cmd.CommandType = CommandType.Text;
                Table1 = new DataTable();
                adapter1 = new SqlDataAdapter(cmd);
                adapter1.Fill(Table1);
                comboBox2.DataSource = Table1;
                comboBox2.DisplayMember = "Name";
                comboBox2.ValueMember = "ID";
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Данные не введены");
            }
            else
            {
                try
                {
                    dataBase.openConnection();
                    
                    string quary = "INSERT INTO Modules (Product, Materials, Amount) VALUES('" + comboBox1.SelectedValue + "','" + comboBox2.SelectedValue + "','" + textBox3.Text + "')";
                    SqlCommand cmd = new SqlCommand(quary, dataBase.getConnection());
                    cmd.ExecuteNonQuery();
                    Table.Clear();
                    adapter.Fill(Table);
                    dataGridView1.DataSource = Table;
                    textBox3.Text = "";
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
                if (textBox3.Text == "")
                {
                    MessageBox.Show("Данные не выбраны");
                }
                else
                {
                    try
                    {
                        dataBase.openConnection();
                        string quary = "DELETE FROM Modules WHERE ID ='" + textBox1.Text +"';";

                        SqlCommand cmd = new SqlCommand(quary, dataBase.getConnection());
                        cmd.ExecuteNonQuery();
                        Table.Clear();
                        adapter.Fill(Table);
                        dataGridView1.DataSource = Table;
                        textBox3.Text = "";
                
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Данные не выбраны");
            }
            else
            {
                try
                {
                    dataBase.openConnection();
                    string quary = "UPDATE Modules SET Product = '" + comboBox1.SelectedValue + "',Materials='" +
                                   comboBox2.SelectedValue + "',Amount='" + textBox3.Text + "' WHERE ID ='" +
                                   textBox1.Text + "';";
                    SqlCommand cmd = new SqlCommand(quary, dataBase.getConnection());
                    cmd.ExecuteNonQuery();
                    Table.Clear();
                    adapter.Fill(Table);
                    dataGridView1.DataSource = Table;
                    textBox3.Text = "";

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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}