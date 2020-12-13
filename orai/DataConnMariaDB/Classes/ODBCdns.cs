using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;


namespace DataConnMariaDB.Classes
{
    class ODBCClass : IDisposable
    {
        OdbcConnection oConnection;
        OdbcCommand oCommand;

        // Ez a konstruktor  
        /// <param name="DataSourceName">string: Ez a *.dsn adatforrás neve</param>  
        public ODBCClass(string DataSourceName)
        {
            // Azonnali kapcsolat  
            oConnection = new OdbcConnection("Dsn=" + DataSourceName);
            try
            {
                // Nyissa meg a kapcsolatot  
                oConnection.Open();
                // Értesítse a felhasználót a kapcsolat megnyitásáról  
                Console.WriteLine("A kapcsolat az adatbázissal létre jött.");
                
            }
            catch (OdbcException caught)
            {
                Console.WriteLine(caught.Message);
                Console.Read();
            }
        }
        // A kapcsolat bezárására szolgál    
        public void CloseConnection()
        {
            oConnection.Close();
        }

        // Ez a függvény érvényes odbc kapcsolatot ad vissza  
        // <param name="Query">string: Ez az SQL lekérdezés</param>  
        public OdbcCommand GetCommand(string Query)
        {
            oCommand = new OdbcCommand();
            oCommand.Connection = oConnection;
            oCommand.CommandText = Query;
            return oCommand;
        }

        // Ez a módszer bezárja a tényleges kapcsolatot  
        public void Dispose()
        {
            oConnection.Close();
        }
    }

    // Kapcsolati mód
    class Connected
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
