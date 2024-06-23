using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Test"].ConnectionString);
        public int userID;
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isvalid())
            {
                SqlCommand command = new SqlCommand("INSERT INTO userdetails (firstname,lastname,email,phone,address) VALUES (@firstname,@lastname,@email,@phone,@address)", connection);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@firstname", txt_Firstname.Text);
                command.Parameters.AddWithValue("@lastname", txt_lastname.Text);
                command.Parameters.AddWithValue("@email", txt_email.Text);
                command.Parameters.AddWithValue("@phone", txt_phone.Text);
                command.Parameters.AddWithValue("@address", txt_address.Text);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("New user is added!","saved",MessageBoxButtons.OK,MessageBoxIcon.Information);
                GetUserRecord();
                Cleartextbox();
            }
        }

        private bool isvalid()
        {
           if(txt_Firstname.Text== string.Empty)
            {
                MessageBox.Show("firstname is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }else if(txt_lastname.Text== string.Empty)
            {
                MessageBox.Show("Lastname is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
           /* string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            Regex regex = new Regex(pattern);*/
           else if(txt_email.Text == string.Empty)
            {
                MessageBox.Show("Email is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
           else if(txt_phone.Text == string.Empty)
            {
                MessageBox.Show("Phone number is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
           else if(txt_address.Text == string.Empty)
            {
                MessageBox.Show("Address is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            GetUserRecord();
        }

        private void GetUserRecord()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM userdetails",connection);
            DataTable dataTable = new DataTable();
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            dataTable.Load(reader);
            connection.Close();
            user_Grid_View.DataSource = dataTable;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cleartextbox();
        }

        private void Cleartextbox()
        {
            userID = 0;
            txt_Firstname.Clear();
            txt_lastname.Clear();
            txt_email.Clear();
            txt_phone.Clear();
            txt_address.Clear();
            txt_Firstname.Focus();
        }

        private void user_Grid_View_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            userID = Convert.ToInt32(user_Grid_View.SelectedRows[0].Cells[0].Value);
            txt_Firstname.Text = user_Grid_View.SelectedRows[0].Cells[1].Value.ToString();
            txt_lastname.Text = user_Grid_View.SelectedRows[0].Cells[2].Value.ToString();
            txt_email.Text = user_Grid_View.SelectedRows[0].Cells[3].Value.ToString();
            txt_phone.Text = user_Grid_View.SelectedRows[0].Cells[4].Value.ToString();
            txt_address.Text = user_Grid_View.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(userID > 0)
            {
                SqlCommand command = new SqlCommand("UPDATE userdetails SET firstname=@firstname,lastname=@lastname,email=@email,phone=@phone,address=@address WHERE id= @id", connection);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@firstname", txt_Firstname.Text);
                command.Parameters.AddWithValue("@lastname", txt_lastname.Text);
                command.Parameters.AddWithValue("@email", txt_email.Text);
                command.Parameters.AddWithValue("@phone", txt_phone.Text);
                command.Parameters.AddWithValue("@address", txt_address.Text);
                command.Parameters.AddWithValue("@id", this.userID);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("User updated succesfully.", "updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetUserRecord();
                Cleartextbox();
            }else
            {
                MessageBox.Show("Please select a student to update!", "select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(userID > 0)
            {
                SqlCommand command = new SqlCommand("DELETE FROM userdetails WHERE id=@id ", connection);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@id", this.userID);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("User deleted successfully.", "deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetUserRecord();
                Cleartextbox();
            }
            else
            {
                MessageBox.Show("Please select a student to delete!", "delete?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
