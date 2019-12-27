using System;
using Oracle.ManagedDataAccess.Client;

namespace defaultGenerateDuiBi.DAL
{
    public class TestOracleDAL
    {
        private string config =
            @"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.206.1.24)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORCL)));Persist Security Info=True;User ID=wfm;Password=wfm;";

        public void getconn()
        {
            OracleConnection oracleDB = new OracleConnection(config);
            oracleDB.Open();
            Console.WriteLine("ok");
            oracleDB.Close();


        }
    }
}