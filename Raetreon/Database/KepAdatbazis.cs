using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Raetreon
{
    public class KepAdatbazis
    {
        private static KepAdatbazis uniqueInstance = null;
        private KepAdatbazis() { }
        public static KepAdatbazis getInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new KepAdatbazis();
            return uniqueInstance;
        }

        public List<string> HarcosKepLekerdez()
        {            
            List<string> kepek = new List<string>();
            
            string connectionString = "Driver={Microsoft Excel Driver (*.xls, *.xlsx, *.xlsm, *.xlsb)};" + "DBQ=" + Environment.CurrentDirectory + @"\Fajlok\DB\kepadatbazis.xlsx" + ";ReadOnly=0;";

            string queryString =
                "SELECT * FROM [Harcoskepek$]";
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
                        kepek.Add((string)reader[0]);                        
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }                
                return kepek;
            }
        }

        public List<string> IjaszKepLekerdez()
        {
            List<string> kepek = new List<string>();

            string connectionString = "Driver={Microsoft Excel Driver (*.xls, *.xlsx, *.xlsm, *.xlsb)};" + "DBQ=" + Environment.CurrentDirectory + @"\Fajlok\DB\kepadatbazis.xlsx" + ";ReadOnly=0;";

            string queryString =
                "SELECT * FROM [Ijaszkepek$]";
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
                        kepek.Add((string)reader[0]);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return kepek;
            }
        }

        public List<string> MagusKepLekerdez()
        {
            List<string> kepek = new List<string>();

            string connectionString = "Driver={Microsoft Excel Driver (*.xls, *.xlsx, *.xlsm, *.xlsb)};" + "DBQ=" + Environment.CurrentDirectory + @"\Fajlok\DB\kepadatbazis.xlsx" + ";ReadOnly=0;";

            string queryString =
                "SELECT * FROM [Maguskepek$]";
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
                        kepek.Add((string)reader[0]);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return kepek;
            }
        }

        public List<string> EllenKepLekerdez()
        {
            List<string> kepek = new List<string>();

            string connectionString = "Driver={Microsoft Excel Driver (*.xls, *.xlsx, *.xlsm, *.xlsb)};" + "DBQ=" + Environment.CurrentDirectory + @"\Fajlok\DB\kepadatbazis.xlsx" + ";ReadOnly=0;";

            string queryString =
                "SELECT * FROM [Ellenfelkepek$]";
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
                        kepek.Add((string)reader[0]);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return kepek;
            }
        }
    }
}
