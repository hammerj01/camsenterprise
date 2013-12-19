using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SalesInventory.FORMS;
using prjCamsEnterprise.Classes;

namespace SalesInventory
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //Application.EnableVisualStyles();
            ////Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            PUBLIC_VARIABLES.db.Server = "localhost";
            PUBLIC_VARIABLES.db.User = "root";
            PUBLIC_VARIABLES.db.Pw = "jr101210";
            PUBLIC_VARIABLES.db.Db = "dbcams_inventory";
            if (PUBLIC_VARIABLES.db.Connect() == true) {
                mainSalesInventory main = new mainSalesInventory();
                main.ShowDialog();
            }
        }
    }
}
