using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Threading.Tasks;

namespace Raetreon
{
    public class EllensegAdatbazis
    {
        static Random rnd = new Random();

        private static EllensegAdatbazis uniqueInstance = null;
        private EllensegAdatbazis() { }
        public static EllensegAdatbazis getInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new EllensegAdatbazis();
            return uniqueInstance;
        }
        public List<Ellenseg> EllensegLekerdez()
        {
            EllensegRaktar er = EllensegRaktar.getInstance();
            List<string> ellensegnevek = new List<string>();
            List<int> maxeleterok = new List<int>();            
            List<string> kepek = new List<string>();

            FegyverAdatbazis fa = FegyverAdatbazis.getInstance();
            List<KozelharciF> khf = fa.KhFegyverLekerdez();

            string connectionString = "Driver={Microsoft Excel Driver (*.xls, *.xlsx, *.xlsm, *.xlsb)};" + "DBQ=" + Environment.CurrentDirectory + @"\Fajlok\DB\hosadatbazis.xlsx" + ";ReadOnly=0;";

            string queryString =
                "SELECT * FROM [Harcosok$]";
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

                        ellensegnevek.Add((string)reader[0]);
                        maxeleterok.Add(int.Parse(reader[1].ToString()));
                        kepek.Add((string)reader[2]);
                    }
                    reader.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                for (int i = 0; i < ellensegnevek.Count; i++)
                {
                    Ellenseg ujellenseg = new Ellenseg();
                    ujellenseg.nev = ellensegnevek[i];
                    ujellenseg.maxeletero = maxeleterok[i];
                    ujellenseg.eletero = 1000;
                    ujellenseg.kaszt = "Harcos";
                    ujellenseg.ellenfegyver = khf[rnd.Next(0, khf.Count)];
                    //ujellenseg.kep = kepek[i];
                    er.JatEllensegHozzaad(ujellenseg);
                }
                return er.jatellenseg;
            }
        }
    }
}
