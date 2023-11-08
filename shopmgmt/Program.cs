using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopmgmt
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new shopmgmt.Form1());
            //Application.Run(new shopmgmt.updateCustomerInfo());
            //Application.Run(new shopmgmt.mobileStock());
            //  Application.Run(new shopmgmt.Admin_loginform());
            //Application.Run(new shopmgmt.inventory());
            //Application.Run(new shopmgmt.Customerinfo());
           // Application.Run(new shopmgmt.serachMobile());
          // Application.Run(new shopmgmt.searchCustomer());
          Application.Run(new shopmgmt.SellInfo());

        }
    }
}
