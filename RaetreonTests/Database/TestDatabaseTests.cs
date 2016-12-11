using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raetreon.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace Raetreon
{
    [TestClass()]
    public class TestDatabaseTests
    {
        [TestMethod()]
        public void AdatbazisbaKiirTest()
        {
            string param1 = "Kis Teszt";
            int param2 = 20;
            string param3 = "ABCD";
            string connectionString = "Driver={Microsoft Excel Driver (*.xls, *.xlsx, *.xlsm, *.xlsb)};" + "DBQ=" + Environment.CurrentDirectory + @"\Fajlok\DB\tesztadatbazis.xlsx" + ";ReadOnly=0;";

            OdbcConnection con = new OdbcConnection(connectionString);
            con.Open();
            string query = "insert into [Teszt$] (Teszt0,Teszt1,Teszt2) values (?,?,?)";
            OdbcCommand cmd = new OdbcCommand(query, con);
            cmd.Parameters.AddWithValue("?", param1);
            cmd.Parameters.AddWithValue("?", param2);
            cmd.Parameters.AddWithValue("?", param3);
            cmd.ExecuteNonQuery();// has error
            con.Close();

            List<TesztOsztaly> elvartteszt = TestDatabase.AdatbazistLekerdez();
            Assert.AreEqual(param1, elvartteszt[0].teszt0);
        }        
    }
}