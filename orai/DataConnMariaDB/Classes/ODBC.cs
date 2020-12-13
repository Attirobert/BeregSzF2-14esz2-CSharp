using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace DataConnMariaDB.Classes
{
    public class ODBCClass2 : IDisposable
    {
// https://www.c-sharpcorner.com/uploadfile/yougerthen/connect-to-mysql-database-via-odbc-without-using-dsn-part-ii/

        private string _Password;
        public string Server {get; set;}
        public string Port { get; set; }
        public string DataBaseName { get; set; }
        public string UserID { get; set; }
        public string Password { set { _Password = value; }}
        //Set a query  
        public string Query { get; set; }
        //Define a private connection  
        private OdbcConnection myConnection;
        //Define a command  
        OdbcCommand myCommand;

        public ODBCClass2(string Server, string Port, string DataBaseName, string UserID, string Password, string Query)
        {
            this.Server = Server;
            this.Port = Port;
            this.DataBaseName = DataBaseName;
            this.UserID = UserID;
            this.Password = Password;
            this.Query = Query;

            myConnection = new OdbcConnection();
            myConnection.ConnectionString = "DRIVER={MySQL ODBC 3.51 Driver};SERVER=" + Server + "; PORT=" + Port + ";DATABASE= " + DataBaseName + ";UID= " + UserID + ";PWD=" + Password;
            try
            {
                //Open the connection  
                myConnection.Open();
                //Notify the user that the connection is opened  
                Console.WriteLine("Connected to the data base");
                //Create a new command object  
                myCommand = new OdbcCommand(Query, myConnection);
                /* CommandBehavior.CloseConnection option forces the connection to close if 
                 somethig id wrong*/
            }
            catch (OdbcException caught)
            {
                //TO DO Deal with  the exception  
            }
            catch (InvalidOperationException caught)
            {
                //TO DO Deal with  the exception  
            }
        }
        /// <summary>  
        /// OdbcCommand : This method returns a command object  
        /// </summary>  
        /// <param name="Query">string: This is the sql query</param>  
        /// <returns>returns an OdbcCommand</returns>  

        /// <summary>  
        /// void: It is used to close the connection if you work within disconnected  
        /// mode  
        /// </summary>  
        public void CloseConnection()
        {
            myConnection.Close();
        }
        public OdbcCommand GetOdbcCommand()
        {
            //Returns a command object    
            return myCommand;
        }
        //When the object is disposed the connection is  closed  
        public void Dispose()
        {
            myConnection.Close();
        }
    }

    class Connected2
    {
        // Kapcsolati mód
        public void Oconnected(string dns, string sql)
        {
            using (ODBCClass o = new ODBCClass(dns))
            {
                OdbcCommand oCommand = o.GetCommand(sql);
                OdbcDataReader oReader = oCommand.ExecuteReader();
                while (oReader.Read())
                {
                    // Sorok feldolgozása
                }
            }
        }

        // Kapcsolat nélküli mód
        public void Odisconnected(string dns, string sql)
        {
            using (ODBCClass o = new ODBCClass(dns))
            {
                OdbcCommand oCommand = o.GetCommand(sql);
                OdbcDataAdapter oAdapter = new OdbcDataAdapter(oCommand);
                DataSet ds = new DataSet();
                oAdapter.Fill(ds);

                // Dataset használata....  
            }
        }
    }
}
