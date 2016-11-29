using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Raetreon
{
    class KerdesAdatbazis
    {
        private static KerdesAdatbazis uniqueInstance = null;
        private KerdesAdatbazis() { }
        public static KerdesAdatbazis getInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new KerdesAdatbazis();
            return uniqueInstance;
        }

        public List<string> KerdesLekerdez()
        {
            KerdesRaktar kr = KerdesRaktar.getInstance();            
            List<string> kerdesek = new List<string>();                      

            string connectionString = "Driver={Microsoft Excel Driver (*.xls, *.xlsx, *.xlsm, *.xlsb)};" + "DBQ=" + Environment.CurrentDirectory + @"\Fajlok\DB\kerdesadatbazis.xlsx" + ";ReadOnly=0;";

            string queryString =
                "SELECT * FROM [Kerdesek$]";
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

                        kerdesek.Add((string)reader[0]);                                                
                    }
                    reader.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }                
                return kerdesek;

            }
        }

        public List<string> ValaszLekerdez()
        {
            KerdesRaktar kr = KerdesRaktar.getInstance();           
            List<string> valaszok = new List<string>();

            string connectionString = "Driver={Microsoft Excel Driver (*.xls, *.xlsx, *.xlsm, *.xlsb)};" + "DBQ=" + Environment.CurrentDirectory + @"\Fajlok\DB\kerdesadatbazis.xlsx" + ";ReadOnly=0;";

            string queryString =
                "SELECT * FROM [Valaszok$]";
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
                        valaszok.Add((string)reader[0]);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }                
                return valaszok;

            }
        }
    }
}
