﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SalesInventory.FORMS
{
    public partial class mainSalesInventory : Form
    {
        public mainSalesInventory()
        {
            InitializeComponent();
        }

        private void mainSalesInventory_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void stocksToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmStockList frm = new frmStockList();
            frm.ShowDialog();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategory cat = new frmCategory();
            cat.ShowDialog();
        }
    }
}
