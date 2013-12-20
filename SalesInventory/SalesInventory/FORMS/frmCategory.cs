using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using prjCamsEnterprise.Classes;

namespace SalesInventory.FORMS
{
    public partial class frmCategory : SalesInventory.FORMS.MyBaseList
    {
        c_Category cat;
        public frmCategory()
        {
            InitializeComponent();
            this.cat = new c_Category(); 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.cat.pcategory_name = txtCategory.Text;
            this.cat.save();
            this.cat.LoadCategory(this.listView1);
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            this.cat.LoadCategory(this.listView1);
        }
    }
}
