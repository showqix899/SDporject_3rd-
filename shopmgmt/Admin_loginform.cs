using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopmgmt
{
    public partial class Admin_loginform : Form
    {
        public Admin_loginform()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DAXTER899\\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
        string messgae = "Done";
        string errorMessage = "Something went wrong";
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void admin_login(object sender, EventArgs e)
        {
            
        }
    }
}
