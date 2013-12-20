using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SalesInventory.FORMS
{
    public partial class frmProductEntry : Form
    {
        public frmProductEntry()
        {
            InitializeComponent();
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
            frmUnitOfMeasure frm = new frmUnitOfMeasure();
            frm.ShowDialog();
        }
    }
}
