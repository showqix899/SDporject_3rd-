using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace shopmgmt
{    

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DAXTER899\\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
        string messgae = "Done";
        string errorMessage = "Something went wrong";
        
        private void Submit(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                var insertQuery = "insert into registrantion values(@username,@email,@phone,@password,@type)";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@username", Username_r.Text);
                cmd.Parameters.AddWithValue("@email", email_r.Text);
                cmd.Parameters.AddWithValue("@phone", phone_r.Text);
                cmd.Parameters.AddWithValue("@password", pass_r.Text);
                cmd.Parameters.AddWithValue("@type", comboBox1.SelectedItem);
                cmd.ExecuteNonQuery();
                conn.Close();
                Username_r.Clear();
                email_r.Clear();
                phone_r.Clear();
                pass_r.Clear();
                comboBox1.Items.Clear();
                MessageBox.Show(messgae);
            }
            catch {

                MessageBox.Show(errorMessage);
            
            }
           

        }

        private void Login(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from registrantion where username=@username and password = @password", conn);
            cmd.Parameters.AddWithValue("@username", login_name.Text);
            cmd.Parameters.AddWithValue("@phone",login_name.Text);
            cmd.Parameters.AddWithValue("@password",login_pass.Text);
            if (login_name.Text== "")
            {
                MessageBox.Show("Enter Username");

            }
            else if (login_pass.Text == "")
            {
                MessageBox.Show("Enter password");
            }
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show(messgae);
                login_name.Clear();
                login_pass.Clear();
                Home home = new Home();
                home.Show();
                home.Close();
                
            }
            else
            {
                MessageBox.Show("invalid username or password");
            }


        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        
    }
}
