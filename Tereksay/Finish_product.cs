using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2Tereksay
{
    public partial class Finish_product : Form
    {
        public Finish_product()
        {
            InitializeComponent();
        }
        private DataBase dataBase = new DataBase();
        private DataTable Table, Table1 = null;
        private SqlDataAdapter adapter, adapter1 = null;
        private void Finish_product_Load(object sender, EventArgs e)
        {
            dataBase.openConnection();
            string query = "SELECT * FROM Product_release INNER JOIN Product ON Product_release.Product = Product.ID";
            adapter = new SqlDataAdapter( query, dataBase.getConnection());
            Table = new DataTable();
            adapter.Fill(Table);
            dataGridView1.DataSource = Table;
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["ID"].ReadOnly = true;
            textBox3.Visible = false;
            LoadCombo();
            
        }


        private void LoadCombo()
        {
            string sql1 = "SELECT * FROM Product";
            using (SqlCommand cmd = new SqlCommand(sql1, dataBase.getConnection()))
            {
                cmd.CommandType = CommandType.Text;
                Table1 = new DataTable();
                adapter1 = new SqlDataAdapter(cmd);
                adapter1.Fill(Table1);
                comboBox1.DataSource = "Table";
                comboBox1.ValueMember = "ID";
                comboBox1.DisplayMember = "Name";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Данные не введены");
            }
            else
            {
                try
                {
                    dataBase.openConnection();
                    
                    string quary = "INSERT INTO Product_release (Product, Amount, Date) VALUES('" + comboBox1.SelectedValue + "','" + textBox2.Text + "','" + dateTimePicker1.Value + "')";
                    SqlCommand cmd = new SqlCommand(quary, dataBase.getConnection());
                    cmd.ExecuteNonQuery();
                    Table.Clear();
                    adapter.Fill(Table);
                    dataGridView1.DataSource = Table;
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
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Данные не выбраны");
                }
                else
                {
                    try
                    {
                        dataBase.openConnection();
                        string quary = "DELETE FROM Product_release WHERE ID ='" + textBox3.Text +"';";

                        SqlCommand cmd = new SqlCommand(quary, dataBase.getConnection());
                        cmd.ExecuteNonQuery();
                        Table.Clear();
                        adapter.Fill(Table);
                        dataGridView1.DataSource = Table;
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
                    string quary = "UPDATE Product_release SET Product = '" + comboBox1.SelectedValue + "',Amount='" +
                                   textBox2.Text + "' WHERE ID ='" +
                                   textBox3.Text + "';";
                    SqlCommand cmd = new SqlCommand(quary, dataBase.getConnection());
                    cmd.ExecuteNonQuery();
                    Table.Clear();
                    adapter.Fill(Table);
                    dataGridView1.DataSource = Table;
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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}