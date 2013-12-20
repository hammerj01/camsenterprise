using System;
using System.Collections.Generic;
using System.Text;

namespace prjCamsEnterprise.Classes
{
     class c_Supplier
    {
        private int supplier_id;
        private String supplier_name;
        private String address;
        private string contact_no;
    
        public int psupplier_id
        {
            get
            {
                //throw new System.NotImplementedException();
                return this.supplier_id;
            }
            set
            {
                this.supplier_id = value;
            }
        }

        public String psupplier_name
        {
            get
            {
                return this.supplier_name;

            }
            set
            {
                this.supplier_name = value;
            }
        }

        public String paddress
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }
        }

        public String pcontact_no
        {
            get
            {
               // throw new System.NotImplementedException();
                return this.contact_no;
            }
            set
            {
                this.contact_no = value;
            }
        }

        public void LoadToSupplier()
        {
            //throw new System.NotImplementedException();
        }
    }
}
