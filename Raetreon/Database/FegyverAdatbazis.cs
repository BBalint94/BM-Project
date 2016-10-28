using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace Raetreon
{
    public class FegyverAdatbazis
    {
        private static FegyverAdatbazis uniqueInstance = null;
        private FegyverAdatbazis() { }
        public static FegyverAdatbazis getInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new FegyverAdatbazis();
            return uniqueInstance;
        }
        public List<KozelharciF> KhFegyverLekerdez()
        {
            FegyverRaktar fer = FegyverRaktar.getInstance();
            List<string> khf = new List<string>();
            List<int> seb = new List<int>();
            string connectionString = "Driver={Microsoft Excel Driver (*.xls, *.xlsx, *.xlsm, *.xlsb)};" + "DBQ=" + Environment.CurrentDirectory + @"\Fajlok\DB\adatbazis.xlsx" + ";ReadOnly=0;";

            string queryString =
                "SELECT * FROM [KozelharciF$]";
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

                        khf.Add((string)reader[0]);
                        seb.Add(int.Parse(reader[1].ToString()));
                    }
                    reader.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                for (int i = 0; i < khf.Count; i++)
                {
                    KozelharciF ujf = new KozelharciF();
                    ujf.nev = khf[i];
                    ujf.sebzes = seb[i];
                    fer.KhFegyverHozzaad(ujf);
                }
                return fer.khfegyverek;
            }
        }

        public List<TavolsagiF> TavFegyverLekerdez()
        {
            FegyverRaktar fer = FegyverRaktar.getInstance();
            List<string> tavf = new List<string>();
            List<int> seb = new List<int>();

            string connectionString = "Driver={Microsoft Excel Driver (*.xls, *.xlsx, *.xlsm, *.xlsb)};" + "DBQ=" + Environment.CurrentDirectory + @"\Fajlok\DB\adatbazis.xlsx" + ";ReadOnly=0;";

            string queryString =
                "SELECT * FROM [TavolsagiF$]";
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

                        tavf.Add((string)reader[0]);
                        seb.Add(int.Parse(reader[1].ToString()));
                    }
                    reader.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                for (int i = 0; i < tavf.Count; i++)
                {
                    TavolsagiF ujf = new TavolsagiF();
                    ujf.nev = tavf[i];
                    ujf.sebzes = seb[i];
                    fer.TavFegyverHozzaad(ujf);
                }
                return fer.tavfegyverek;
            }
        }
        public List<MagikusF> MagFegyverLekerdez()
        {
            FegyverRaktar fer = FegyverRaktar.getInstance();
            List<string> magf = new List<string>();
            List<int> seb = new List<int>();

            string connectionString = "Driver={Microsoft Excel Driver (*.xls, *.xlsx, *.xlsm, *.xlsb)};" + "DBQ=" + Environment.CurrentDirectory + @"\Fajlok\DB\adatbazis.xlsx" + ";ReadOnly=0;";

            string queryString =
                "SELECT * FROM [MagikusF$]";
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

                        magf.Add((string)reader[0]);
                        seb.Add(int.Parse(reader[1].ToString()));
                    }
                    reader.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                for (int i = 0; i < magf.Count; i++)
                {
                    MagikusF ujf = new MagikusF();
                    ujf.nev = magf[i];
                    ujf.sebzes = seb[i];
                    fer.MagFegyverHozzaad(ujf);
                }
                return fer.magfegyverek;
            }
        }
    }
}
