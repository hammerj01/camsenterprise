using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace prjCamsEnterprise.Classes
{
    class Database
    {
        //local variables
        private string _server = "";
        private string _user = "";
        private string _pw = "";
        private string _db = "";
        public MySqlDataReader reader;
        public MySqlConnection conn = new MySqlConnection();

        //getters and setters
        #region settersAndGetters
        public string Server
        {
            set { this._server = value; }
            get { return this._server; }
        }

        public string User
        {
            set { this._user = value; }
            get { return this._user; }
        }

        public string Pw
        {
            set { this._pw = value; }
            get { return this._pw; }
        }

        public string Db
        {
            set { this._db = value; }
            get { return this._db; }
        }
        #endregion

        //connect methods
        public bool Connect()
        {
            string server_string;
            server_string = "server = " + this._server +
                          ";username = " + this._user +
                          ";password = " + this._pw +
                          ";database =" + this._db;
            this.conn.ConnectionString = server_string;
            try
            {
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); 
                return false;
            }
        }


        //customized execute method
        public MySqlDataReader execute(string sql)
        {
            try
            {
                MySqlCommand comm = new MySqlCommand();
                comm.Connection = this.conn;
                comm.CommandText = sql;
                this.reader = comm.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //this.reader.Close();
            return this.reader;
        }


        //customized executeNonReader method
        public void executeNonReader(string sql)
        {
            try
            {
                MySqlCommand comm = new MySqlCommand();
                comm.Connection = this.conn;
                comm.CommandText = sql;
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public double getLastId()
        {
            double id = 0d;
            string sql;
            MySqlCommand comm = new MySqlCommand();
            sql = "SELECT last_insert_id()";
            comm.CommandText = sql;
            comm.Connection = this.conn;
            //this.reader = comm.ExecuteReader();
            this.reader = this.execute(comm.CommandText);
            while (reader.Read())
            {
                id = reader.GetInt64(0);
            }
            this.reader.Close();
            return id;
        }
    }
}
