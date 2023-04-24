using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2Tereksay
{
    public partial class Material : Form
    {
        public Material()
        {
            InitializeComponent();
        }
        private DataBase dataBase = new DataBase();
        private DataTable Table, Table1 = null;
        private SqlDataAdapter adapter, adapter1 = null;

        private void Material_Load(object sender, EventArgs e)
        {
            dataBase.openConnection();
            Load_combobox();
            string query = "SELECT Materials.Name, Materials.Amount, Materials.Cost_purchased, Postman.Name AS Expr1 FROM Materials INNER JOIN Postman ON Materials.Postman = Postman.ID";
            adapter = new SqlDataAdapter( query, dataBase.getConnection());
            Table = new DataTable();
            adapter.Fill(Table);
            dataGridView1.DataSource = Table;
        }

        private void Load_combobox()
        {
            string sql = "SELECT * FROM Postman";
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
        }

        private void dataGridView1_CellClic(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
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
                                
                                string quary = "INSERT INTO Materials (Name, Amount, Cost_purchased, Postman) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text +"','" + comboBox1.SelectedValue + "')";
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
                        string quary = "DELETE FROM Materials WHERE Name ='" + textBox1.Text + "';";
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
                                string quary = "UPDATE Materials SET Name = '" + textBox1.Text + "',Amount='" + textBox2.Text + "',Cost_purchased='" + textBox3.Text + "',Postman='" + comboBox1.SelectedValue + "' WHERE Name='" + textBox1.Text + "';";
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