using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalYearProject
{
    class databaseConnection
    {
        private string sql_string; //will hold sql query string
        private string strCon; //location of database
        System.Data.SqlClient.SqlDataAdapter da1; //sql data adapter

        public string sql //write only property for the sql_string
        {
            set
            {
                sql_string = value;
            }
        }
        public string connection_string //write only property for the database location variable
        {
            set
            {
                strCon = value;
            }
        }
        public System.Data.DataSet GetConnection //read only property that calls the method DataSet()
        {
            get
            {
                return DataSet();
            }
        }
        private System.Data.DataSet DataSet() //connects to the database and fills the dataset
        {
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(strCon); //create a variable of sqlconnection type
            con.Open(); //open the connection
            da1 = new System.Data.SqlClient.SqlDataAdapter(sql_string, con); //setting the sql data adapter
            System.Data.DataSet dat_set = new System.Data.DataSet(); //creating the data set
            da1.Fill(dat_set, "Table_Data_1"); //filling the dataset and naming the fill table_data_1

            con.Close(); //closing the connection
            return dat_set; //returning the dataset
        }
    }
}
