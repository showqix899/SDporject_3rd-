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

namespace shopmgmt
{
    public partial class mobileStock : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DAXTER899\\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
        string Message = "DONE";
        String errorMessage = "Something went wrong";
       
        public mobileStock()
        {
            InitializeComponent();
            
        }

        private void ADD_stock(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                var inserQuery = "insert into stockTable values(@id,@brand,@name,@colour,@ram,@rom,@processor)";
                SqlCommand cmd = new SqlCommand(inserQuery, conn);
                cmd.Parameters.AddWithValue("@id", addMobileId.Text);
                cmd.Parameters.AddWithValue("@brand", brand.SelectedItem);
                cmd.Parameters.AddWithValue("@name", mobileName.Text);
                cmd.Parameters.AddWithValue("@colour", colour.SelectedItem);
                cmd.Parameters.AddWithValue("@ram", ram.SelectedItem);
                cmd.Parameters.AddWithValue("rom", rom.SelectedItem);
                cmd.Parameters.AddWithValue("processor", processor.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                addMobileId.Clear();
                brand.Items.Clear();
                mobileName.Clear();
                colour.Items.Clear();
                ram.Items.Clear();
                rom.Items.Clear();
                processor.Clear();
                MessageBox.Show(Message);
            }
            catch
            {
                MessageBox.Show(errorMessage);
            }
        }

      

        private void addCustomerInfo(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                var insertQuery = "insert into customer_info values(@customer_id,@customer_name,@customer_address,@customer_phone,@customer_email)";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@customer_id",customerid.Text);
                cmd.Parameters.AddWithValue("@customer_name",customername.Text);
                cmd.Parameters.AddWithValue("@customer_address",customeraddress.Text);
                cmd.Parameters.AddWithValue("@customer_phone",customerphone.Text);
                cmd.Parameters.AddWithValue("@customer_email",customeremail.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(Message);
            }
            catch
            {
                MessageBox.Show(errorMessage);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
