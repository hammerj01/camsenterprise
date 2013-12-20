using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjCamsEnterprise.Classes
{
    class c_StockIn:BaseClass
    {
        private int quantity;
        private double price;
        private string stockin_date;

        public c_StockIn() : base()
        {
            this.quantity = 0;
            this.price = 0d;

        }

        public void Save()
        {
            base.addTable("tstockin");


        }

        #region "GETTERS AND SETTERS"

        public string pdate_stockin
        {
            get
            {
                return this.stockin_date;
            }
            set
            {
                this.stockin_date = value;
            }
        }

        public int pquantity
        {
            get
            {
                return this.quantity;
            }
            set
            {
                this.quantity = value;
            }
        }

        public double pprice
        {
            get
            {
               // throw new System.NotImplementedException();
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        #endregion 

    }
}
