using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjCamsEnterprise.Classes
{
    class c_Category:BaseClass
    {
        private int category_id;
        private String category_name;

        public int pcategory_id
        {
            get
            {
              //  throw new System.NotImplementedException();
                return this.category_id;
            }
            set
            {
                this.category_id = value;
            }
        }

        public string pcategory_name
        {
            get
            {
                //throw new System.NotImplementedException();
                return this.category_name;
            }
            set
            {
                this.category_name = value;
            }
        }

        public void LoadCategory()
        {
          //  throw new System.NotImplementedException();
        }
    }
}
