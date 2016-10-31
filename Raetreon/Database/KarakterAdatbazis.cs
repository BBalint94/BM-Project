using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Threading.Tasks;

namespace Raetreon
{
    class KarakterAdatbazis
    {
        private static KarakterAdatbazis uniqueInstance = null;
        private KarakterAdatbazis() { }
        public static KarakterAdatbazis getInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new KarakterAdatbazis();
            return uniqueInstance;
        }
        public List<Harcos> JatHarcosLekerdez()
        {
            KarakterRaktar kar = KarakterRaktar.getInstance();
            List<string> karakternevek = new List<string>();
            List<string> kasztok = new List<string>();
            List<string> fegyverek = new List<string>();

            string connectionString = "Driver={Microsoft Excel Driver (*.xls, *.xlsx, *.xlsm, *.xlsb)};" + "DBQ=" + Environment.CurrentDirectory + @"\Fajlok\DB\jatekosadatbazis.xlsx" + ";ReadOnly=0;";

            string queryString =
                "SELECT * FROM [JatHarcos$]";
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

                        karakternevek.Add((string)reader[0]);
                        kasztok.Add((string)reader[1]);
                        fegyverek.Add((string)reader[2]);
                    }
                    reader.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                for (int i = 0; i < karakternevek.Count; i++)
                {
                    FegyverAdatbazis fa = FegyverAdatbazis.getInstance();
                    List<KozelharciF> fegyverbazis = fa.KhFegyverLekerdez();
                    Harcos ujharcos = new Harcos();
                    ujharcos.nev = karakternevek[i];
                    ujharcos.maxeletero = 1000;
                    ujharcos.eletero = 1000;
                    ujharcos.kep = "Images/Karakterek/harcos1.png";
                    for (int j = 0; j < fegyverbazis.Count; j++)
                    {
                        if (fegyverek[i] == fegyverbazis[j].nev)
                            ujharcos.harcosfegyver = fegyverbazis[j];
                    }
                    kar.JatHarcosHozzaad(ujharcos);
                }
                return kar.jatharcosok;

            }
        }

        public List<Magus> JatMagusLekerdez()
        {
            KarakterRaktar kar = KarakterRaktar.getInstance();
            List<string> karakternevek = new List<string>();
            List<string> kasztok = new List<string>();
            List<string> fegyverek = new List<string>();

            string connectionString = "Driver={Microsoft Excel Driver (*.xls, *.xlsx, *.xlsm, *.xlsb)};" + "DBQ=" + Environment.CurrentDirectory + @"\Fajlok\DB\jatekosadatbazis.xlsx" + ";ReadOnly=0;";

            string queryString =
                "SELECT * FROM [JatMagus$]";
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

                        karakternevek.Add((string)reader[0]);
                        kasztok.Add((string)reader[1]);
                        fegyverek.Add((string)reader[2]);
                    }
                    reader.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                for (int i = 0; i < karakternevek.Count; i++)
                {
                    FegyverAdatbazis fa = FegyverAdatbazis.getInstance();
                    List<MagikusF> fegyverbazis = fa.MagFegyverLekerdez();
                    Magus ujmagus = new Magus();
                    ujmagus.nev = karakternevek[i];
                    ujmagus.maxeletero = 1000;
                    ujmagus.eletero = 1000;
                    ujmagus.kep = "Images/Karakterek/mágus1.png";
                    for (int j = 0; j < fegyverbazis.Count; j++)
                    {
                        if (fegyverek[i] == fegyverbazis[j].nev)
                            ujmagus.magusfegyver = fegyverbazis[j];
                    }
                    kar.JatMagusHozzaad(ujmagus);
                }
                return kar.jatmagusok;
            }
        }

        public List<Ijasz> JatIjaszLekerdez()
        {
            KarakterRaktar kar = KarakterRaktar.getInstance();
            List<string> karakternevek = new List<string>();
            List<string> kasztok = new List<string>();
            List<string> fegyverek = new List<string>();

            string connectionString = "Driver={Microsoft Excel Driver (*.xls, *.xlsx, *.xlsm, *.xlsb)};" + "DBQ=" + Environment.CurrentDirectory + @"\Fajlok\DB\jatekosadatbazis.xlsx" + ";ReadOnly=0;";

            string queryString =
                "SELECT * FROM [JatIjasz$]";
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

                        karakternevek.Add((string)reader[0]);
                        kasztok.Add((string)reader[1]);
                        fegyverek.Add((string)reader[2]);
                    }
                    reader.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                for (int i = 0; i < karakternevek.Count; i++)
                {
                    FegyverAdatbazis fa = FegyverAdatbazis.getInstance();
                    List<TavolsagiF> fegyverbazis = fa.TavFegyverLekerdez();
                    Ijasz ujijasz = new Ijasz();
                    ujijasz.nev = karakternevek[i];
                    ujijasz.maxeletero = 1000;
                    ujijasz.eletero = 1000;
                    ujijasz.kep = "Images/Karakterek/Íjász0.png";
                    for (int j = 0; j < fegyverbazis.Count; j++)
                    {
                        if (fegyverek[i] == fegyverbazis[j].nev)
                            ujijasz.ijaszfegyver = fegyverbazis[j];
                    }
                    kar.JatIjaszHozzaad(ujijasz);
                }
                return kar.jatijaszok;

            }
        }

        public void JatHarcosFeltolt(string nev, string kaszt, string fegyver)
        {
            KarakterRaktar kar = KarakterRaktar.getInstance();

            string connectionString = "Driver={Microsoft Excel Driver (*.xls, *.xlsx, *.xlsm, *.xlsb)};" + "DBQ=" + Environment.CurrentDirectory + @"\Fajlok\DB\jatekosadatbazis.xlsx" + ";ReadOnly=0;";

            OdbcConnection con = new OdbcConnection(connectionString);
            con.Open();
            string query = "insert into [JatHarcos$] (Nev,Kaszt,Fegyver) values (?,?,?)";
            OdbcCommand cmd = new OdbcCommand(query, con);
            cmd.Parameters.AddWithValue("?", nev);
            cmd.Parameters.AddWithValue("?", kaszt);
            cmd.Parameters.AddWithValue("?", fegyver);
            cmd.ExecuteNonQuery();// has error
            con.Close();
        }
        public void JatMagusFeltolt(string nev, string kaszt, string fegyver)
        {
            KarakterRaktar kar = KarakterRaktar.getInstance();

            string connectionString = "Driver={Microsoft Excel Driver (*.xls, *.xlsx, *.xlsm, *.xlsb)};" + "DBQ=" + Environment.CurrentDirectory + @"\Fajlok\DB\jatekosadatbazis.xlsx" + ";ReadOnly=0;";

            OdbcConnection con = new OdbcConnection(connectionString);
            con.Open();
            string query = "insert into [JatMagus$] (Nev,Kaszt,Fegyver) values (?,?,?)";
            OdbcCommand cmd = new OdbcCommand(query, con);
            cmd.Parameters.AddWithValue("?", nev);
            cmd.Parameters.AddWithValue("?", kaszt);
            cmd.Parameters.AddWithValue("?", fegyver);
            cmd.ExecuteNonQuery();// has error
            con.Close();
        }
        public void JatIjaszFeltolt(string nev, string kaszt, string fegyver)
        {
            KarakterRaktar kar = KarakterRaktar.getInstance();

            string connectionString = "Driver={Microsoft Excel Driver (*.xls, *.xlsx, *.xlsm, *.xlsb)};" + "DBQ=" + Environment.CurrentDirectory + @"\Fajlok\DB\jatekosadatbazis.xlsx" + ";ReadOnly=0;";

            OdbcConnection con = new OdbcConnection(connectionString);
            con.Open();
            string query = "insert into [JatIjasz$] (Nev,Kaszt,Fegyver) values (?,?,?)";
            OdbcCommand cmd = new OdbcCommand(query, con);
            cmd.Parameters.AddWithValue("?", nev);
            cmd.Parameters.AddWithValue("?", kaszt);
            cmd.Parameters.AddWithValue("?", fegyver);
            cmd.ExecuteNonQuery();// has error
            con.Close();
        }
    }
}
