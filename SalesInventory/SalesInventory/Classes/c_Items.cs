using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjCamsEnterprise.Classes
{
    class c_Items:BaseClass
    {
        private double item_id;
        private String item_name;
        private Int32 item_qty;
        private Double m_price;
        private double srp_price;
        private String item_description;
        private Int32 reorder;
        
        //constructor
       public c_Items() : base()
        {
            this.item_id = 0d;
            this.item_qty = 0;
            this.reorder = 0;
            this.item_name = "";
            this.m_price = 0d;
            this.srp_price = 0d;
            this.item_description = "";
        }

        #region "GETTERS AND SETTERS"

        public Int32 preorder
        {
            get
            {
                return this.reorder;
            }
            set
            {
                this.reorder = value;
            }
        }
        public String pitem_description
        {
            get
            {
                return this.item_description;
            }
            set
            {
                this.item_description = value;
            }
        }

        public double pitem_id
        {
            get
            {
                return this.item_id; 
            }
            set
            {
                this.item_id = value;
            }
        }

        public String pitem_name
        {
            get
            {
                return this.item_name;
            }
            set
            {
                this.item_name = value;
            }
        }

        public double pm_price
        {
            get
            {
                return this.m_price;
            }
            set
            {
                this.m_price = value;
            }
        }

        public double psrp_price
        {
            get
            {
                return this.srp_price;
            }
            set
            {
                this.srp_price = value;
            }
        }
        public Int32 pitem_qty
        {
            get
            {
                return this.item_qty;
            }
            set
            {
                this.item_qty = value;
            }
        }

        #endregion 

        public void loadtoItems(double itemID)
        {
            string sql = "";
            //items_id, item_name, item_description, item_qty, m_price, srp_price,reorder
            sql = "SELECT * FROM titems WHERE items_id = " + itemID + ";";
            PUBLIC_VARIABLES.db.execute(sql);
            if (PUBLIC_VARIABLES.db.reader.HasRows)
            {
                PUBLIC_VARIABLES.db.reader.Read();
                this.pitem_id = Convert.ToDouble(PUBLIC_VARIABLES.db.reader["item_id"].ToString());
                this.pitem_name = PUBLIC_VARIABLES.db.reader["item_name"].ToString();
                this.pitem_description = PUBLIC_VARIABLES.db.reader["item_description"].ToString();
                this.pitem_qty = Convert.ToInt32(PUBLIC_VARIABLES.db.reader["item_qty"].ToString());
                this.pm_price = Convert.ToDouble(PUBLIC_VARIABLES.db.reader["m_price"].ToString());
                this.psrp_price = Convert.ToDouble(PUBLIC_VARIABLES.db.reader["srp_price"].ToString());
                this.preorder = Convert.ToInt32(PUBLIC_VARIABLES.db.reader["reorder"].ToString());
            }
            PUBLIC_VARIABLES.db.reader.Close();
        }

      new  public void save()
        {
            base.addTable("items"); //table name
        }
    }
}
