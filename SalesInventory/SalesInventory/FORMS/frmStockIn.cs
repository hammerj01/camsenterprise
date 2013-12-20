using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SalesInventory.Classes;

namespace SalesInventory.FORMS
{
    public partial class frmStockIn : SalesInventory.FORMS.MyBaseList
    {
        public frmStockIn()
        {
            InitializeComponent();
            var pos = this.PointToScreen(label1.Location);
            pos = pictureBox1.PointToClient(pos);
            label1.Parent = pictureBox1;
            label1.Location = pos;
            label1.BackColor = Color.Transparent;
            label1.Text = "Product Information";

            var pos1 = this.PointToScreen(label2.Location);
            pos1 = pictureBox1.PointToClient(pos1);
            label2.Parent = pictureBox1;
            label2.Location = pos1;
            label2.BackColor = Color.Transparent;
            label2.Text = "Search :";
        }

        private void frmStockIn_Load(object sender, EventArgs e)
        {
            this.Location = new Point(10, 10);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmProductEntry pEntry = new frmProductEntry();
            pEntry.ShowDialog();
        }
    }
}
