using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjCamsEnterprise.Classes;

namespace SalesInventory.FORMS
{
    public partial class frmProductEntry : Form
    {
        c_Items items;
        public frmProductEntry()
        {
            InitializeComponent();
            this.items = new c_Items();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCategory frm = new frmCategory();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
      
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //this.items.pitem_name = d;
        }
    }
}
