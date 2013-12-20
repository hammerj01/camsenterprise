using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjCamsEnterprise.Classes
{
   abstract class BaseClass
    {
        protected List<string> db_field_name; //collection
        protected List<string> values;
        private string sql;
        private string _field;
        private string _val;
        private string table_name;
        private string whereClause;

        //constructor
        public BaseClass()
        {
            this.db_field_name = new List<string>();
            this.values = new List<string>();
            this.sql = "";
            this._field = "";
            this._val = "";
            this.table_name = "";
            this.whereClause = "";
        }

        //adding to where clause
        protected void addWhereClause(string whereValue)
        {
            this.whereClause = whereValue;
        }
        //add table method
        protected void addTable(string _table_name)
        {
            this.table_name = _table_name;
        }
        //addfield method to add field name
        protected void addField(string field)
        {
            this.db_field_name.Add(field);
        }
        //add values method to add values
        protected void addValue(string val)
        {
            string temp = "'" + val + "'";
            this.values.Add(temp);
        }
        //add values override method for value without single qoute
        protected void addValue(string val, bool without_qoute)
        {
            this.values.Add(val);
        }
        //save method to be executed when object performs save action
        protected void save(string msg_value)
        {

            _field = String.Join(",", db_field_name.ToArray());
            _val = String.Join(",", values.ToArray());
            try
            {
                sql = "INSERT INTO " + this.table_name + "(" + _field + ") VALUES(" + _val + ")";
                PUBLIC_VARIABLES.db.executeNonReader(sql);
                MessageBox.Show(msg_value + " saved!", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }
        //overload save method without message prompt after saving
        protected void save()
        {

            _field = String.Join(",", db_field_name.ToArray());
            _val = String.Join(",", values.ToArray());
            try
            {
                sql = "INSERT INTO " + this.table_name + "(" + _field + ") VALUES(" + _val + ")";
                PUBLIC_VARIABLES.db.executeNonReader(sql);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }
        //edit method to be executed when object performs edit action
        protected void edit(string msg_value)
        {
            string keyValue = "";
            _field = string.Join(",", db_field_name.ToArray());
            _val = string.Join(",", values.ToArray());

            for (int i = 0; i < db_field_name.Count; i++)
            {
                if (i == db_field_name.Count - 1)
                {
                    keyValue = keyValue + db_field_name[i] + "=" + values[i] + " WHERE " + this.whereClause;
                }
                else
                {
                    keyValue = keyValue + db_field_name[i] + "=" + values[i] + ",";
                }
            }
            try
            {
                sql = "UPDATE " + this.table_name + " SET " + keyValue;
                PUBLIC_VARIABLES.db.executeNonReader(sql);
                MessageBox.Show(msg_value + " updated!", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }

        protected void delete(string msg_value)
        {
            try
            {
                this.sql = "DELETE FROM " + this.table_name + " WHERE " + this.whereClause;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //reset object values
        protected void reset()
        {
            this.db_field_name = new List<string>();
            this.values = new List<string>();
            this.sql = "";
            this._field = "";
            this._val = "";
            this.table_name = "";
            this.whereClause = "";
        }

    }
}
