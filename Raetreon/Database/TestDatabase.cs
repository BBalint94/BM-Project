using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace Raetreon.Database
{
    static public class TestDatabase
    {
        static public void AdatbazisbaKiir()
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
        }
        static public List<TesztOsztaly> AdatbazistLekerdez()
        {
            List<TesztOsztaly> oszt = new List<TesztOsztaly>();
            List<string> teszt0 = new List<string>();
            List<int> teszt1 = new List<int>();
            List<string> teszt2 = new List<string>();
            string connectionString = "Driver={Microsoft Excel Driver (*.xls, *.xlsx, *.xlsm, *.xlsb)};" + "DBQ=" + Environment.CurrentDirectory + @"\Fajlok\DB\tesztadatbazis.xlsx" + ";ReadOnly=0;";

            string queryString =
                "SELECT * FROM [Teszt$]";
            using (OdbcConnection connection =
                new OdbcConnection(connectionString))
            {

                OdbcCommand command = new OdbcCommand(queryString, connection);

                try
                {
                    connection.Open();
                    OdbcDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {

                        teszt0.Add((string)reader[0]);
                        teszt1.Add(int.Parse(reader[1].ToString()));
                        teszt2.Add((string)reader[2]);
                    }
                    reader.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                for (int i = 0; i < teszt0.Count; i++)
                {
                    TesztOsztaly to = new TesztOsztaly();
                    to.teszt0 = teszt0[i];
                    to.teszt1 = teszt1[i];
                    to.teszt2 = teszt2[i];
                    oszt.Add(to);
                }
                return oszt;
            }
        }
    }
}
