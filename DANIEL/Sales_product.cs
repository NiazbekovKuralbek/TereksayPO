using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2Tereksay
{
    public partial class Sales_product : Form
    {
        public Sales_product()
        {
            InitializeComponent();
        }
        private DataBase dataBase = new DataBase();
        private DataTable Table, Table1, Table2 = null;
        private SqlDataAdapter adapter, adapter1 = null;
        private void Sales_product_Load(object sender, EventArgs e)
        {
            dataBase.openConnection();
            string query = "SELECT Product_release.ID, Product.Name, Product_release.Amount, Product_release.Date FROM Product INNER JOIN Product_release ON Product.ID = Product_release.Product";
            string sql =
                "SELECT Product_sold.ID, Product.Name, Product_sold.Amount, Product_sold.Date FROM Product INNER JOIN Product_sold  ON Product.ID = Product_sold.Product";
            adapter = new SqlDataAdapter( sql, dataBase.getConnection());
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
                comboBox1.DataSource = Table1;
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "ID";
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
                    string quary = "INSERT INTO Product_sold (Product, Amount, Date) VALUES('" + comboBox1.SelectedValue + "','" + textBox2.Text + "','" + dateTimePicker1.Value + "')";
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
                        string quary = "DELETE FROM Product_sold WHERE ID ='" + textBox3.Text +"';";

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
                    string quary = "UPDATE Product_sold SET Product = '" + comboBox1.SelectedValue + "',Amount='" +
                                   textBox2.Text + "',Date='" + dateTimePicker1.Value +"' WHERE ID ='" +
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
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}