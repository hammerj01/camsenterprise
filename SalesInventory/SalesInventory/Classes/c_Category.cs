using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjCamsEnterprise.Classes
{
    class c_Category:BaseClass
    {
        private double category_id;
        private string category_name;

        public double pcategory_id
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
        new public void save() {
            //category_id, category_name
            base.addTable("tcategory");
            base.addField("category_id");
            base.addField("category_name");

            base.addValue("NULL", true);
            base.addValue(this.pcategory_name);

            base.save("New Category Saved!");
        }
        public void update() {
            //category_id, category_name
            base.reset();
            base.addTable("tcategory");
            base.addField("category_id");
            base.addField("category_name");

            base.addValue(this.pcategory_id.ToString(), true);
            base.addValue(this.pcategory_name);

            base.addWhereClause("category_id="+this.pcategory_id);

            base.edit("Category UPdated");
        }

        public void delete() {
            string sql = "DELETE FROM tcategory WHERE category_id = " + this.pcategory_id;
            
        }

        public void LoadCategory(ListView lsv)
        {
          //  throw new System.NotImplementedException();
            lsv.Items.Clear();
            string sql = "SELECT * FROM `dbcams_inventory`.`tcategory`";
            try {
                PUBLIC_VARIABLES.db.execute(sql);
                if(PUBLIC_VARIABLES.db.reader.HasRows){
                    while(PUBLIC_VARIABLES.db.reader.Read()){
                        int i = lsv.Items.Count;
                        lsv.Items.Add(PUBLIC_VARIABLES.db.reader["category_id"].ToString());
                        lsv.Items[i].SubItems.Add(PUBLIC_VARIABLES.db.reader["category_name"].ToString());
                    }
                }
            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
            }
            PUBLIC_VARIABLES.db.reader.Close();
        }

        public void LoadCategory(double id) {
            string sql = "SELECT * FROM `dbcams_inventory`.`tcategory` WHERE category_id="+id;
            try {
                PUBLIC_VARIABLES.db.execute(sql);
                if(PUBLIC_VARIABLES.db.reader.HasRows){
                    PUBLIC_VARIABLES.db.reader.Read();
                    this.pcategory_id = Convert.ToDouble(PUBLIC_VARIABLES.db.reader["category_id"].ToString());
                    this.pcategory_name = PUBLIC_VARIABLES.db.reader["category_name"].ToString();
                }
            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
            }
            PUBLIC_VARIABLES.db.reader.Close();
        }


    }
}
