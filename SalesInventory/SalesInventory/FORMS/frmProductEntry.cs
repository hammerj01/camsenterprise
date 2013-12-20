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
     
        }

        public void getItems()
        { 
            items.pitem_name = txtProductName.Text;
            items.pitem_description = txtProductDetails.Text;
            items.pitem_qty = Convert.ToInt32(txtQty.Text);
            items.pm_price = Convert.ToDouble(txtDealersPrice.Text);
            items.psrp_price = Convert.ToDouble(txtSRP.Text);
            items.preorder = Convert.ToInt32(txtReOrder.Text);


        }

    }
}
