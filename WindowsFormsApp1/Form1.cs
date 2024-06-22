using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Test"].ConnectionString);
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
            this.Close();
        }

        private void btn_signIn_Click(object sender, EventArgs e)
        {
            String username, user_password;
            username = textBox1.Text;
            user_password = textBox2.Text;

            try
            {
                String querry = "SELECT * FROM login WHERE firstname = '" + textBox1.Text + "' AND password = '" + textBox2.Text + "' ";
                SqlDataAdapter adapter = new SqlDataAdapter(querry, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                if(dataTable.Rows.Count> 0)
                {
                    username = textBox1.Text;
                    user_password = textBox2.Text;
                    //page that need to be load
                    Main main = new Main();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login details!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Clear();
                    //to focus the textbox firstname
                    textBox1.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }finally
            {
                connection.Close();
            }

          
        }
    }
}
