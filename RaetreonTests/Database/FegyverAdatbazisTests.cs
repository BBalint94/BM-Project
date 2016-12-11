using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raetreon;
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
    public class FegyverAdatbazisTests
    {
       // [TestMethod()]
        public void getInstanceTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void KhFegyverLekerdezTest()
        {
            FegyverAdatbazis fegy = FegyverAdatbazis.getInstance();
            List<KozelharciF> elvartfegyv = new List<KozelharciF>();
            List<string> elvartkhfegyverek = new List<string>();
            List<int> elvartsebzesek = new List<int>();
            elvartkhfegyverek.Add("tőr");
            elvartkhfegyverek.Add("kés");
            elvartkhfegyverek.Add("szablya");
            elvartkhfegyverek.Add("katana");
            elvartkhfegyverek.Add("láncos buzogány");
            elvartkhfegyverek.Add("tüskés buzogány");
            elvartkhfegyverek.Add("csatabárd");
            elvartkhfegyverek.Add("lándzsa");
            elvartkhfegyverek.Add("rövid kard");
            elvartkhfegyverek.Add("hosszú kard");
            elvartsebzesek.Add(90);
            elvartsebzesek.Add(70);
            elvartsebzesek.Add(120);
            elvartsebzesek.Add(450);
            elvartsebzesek.Add(400);
            elvartsebzesek.Add(350);
            elvartsebzesek.Add(380);
            elvartsebzesek.Add(300);
            elvartsebzesek.Add(240);
            elvartsebzesek.Add(280);
            for (int i = 0; i < elvartkhfegyverek.Count; i++)
            {
                KozelharciF khf = new KozelharciF();
                khf.nev = elvartkhfegyverek[i];
                khf.sebzes = elvartsebzesek[i];
                elvartfegyv.Add(khf);
            }

            List<KozelharciF> lekerdezettfv = new List<KozelharciF>();
            List<string> lekerdezettkhf = new List<string>();
            List<int> lekerdezettseb = new List<int>();
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

                        lekerdezettkhf.Add((string)reader[0]);
                        lekerdezettseb.Add(int.Parse(reader[1].ToString()));
                    }
                    reader.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                for (int i = 0; i < lekerdezettkhf.Count; i++)
                {
                    KozelharciF ujf = new KozelharciF();
                    ujf.nev = lekerdezettkhf[i];
                    ujf.sebzes = lekerdezettseb[i];
                    lekerdezettfv.Add(ujf);
                }
                Assert.AreEqual(elvartfegyv.Count, lekerdezettfv.Count);
                for (int i = 0; i < elvartfegyv.Count; i++)
                {
                    Assert.AreEqual(elvartfegyv[i].nev, lekerdezettfv[i].nev);
                    Assert.AreEqual(elvartfegyv[i].sebzes, lekerdezettfv[i].sebzes);
                }
            }
        }

        [TestMethod()]
        public void TavFegyverLekerdezTest()
        {
            FegyverAdatbazis fegy = FegyverAdatbazis.getInstance();
            List<TavolsagiF> elvartfegyv = new List<TavolsagiF>();
            List<string> elvarttavfegyverek = new List<string>();
            List<int> elvartsebzesek = new List<int>();
            elvarttavfegyverek.Add("parittya");
            elvarttavfegyverek.Add("dobókereszt");
            elvarttavfegyverek.Add("tölgyfa íj");
            elvarttavfegyverek.Add("számszeríj");
            elvarttavfegyverek.Add("hosszú íj");
            elvartsebzesek.Add(90);
            elvartsebzesek.Add(180);
            elvartsebzesek.Add(350);
            elvartsebzesek.Add(450);
            elvartsebzesek.Add(300);
            for (int i = 0; i < elvarttavfegyverek.Count; i++)
            {
                TavolsagiF tavf = new TavolsagiF();
                tavf.nev = elvarttavfegyverek[i];
                tavf.sebzes = elvartsebzesek[i];
                elvartfegyv.Add(tavf);
            }

            List<TavolsagiF> lekerdezettfv = new List<TavolsagiF>();
            List<string> lekerdezetttavf = new List<string>();
            List<int> lekerdezettseb = new List<int>();
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

                        lekerdezetttavf.Add((string)reader[0]);
                        lekerdezettseb.Add(int.Parse(reader[1].ToString()));
                    }
                    reader.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                for (int i = 0; i < lekerdezetttavf.Count; i++)
                {
                    TavolsagiF ujtavf = new TavolsagiF();
                    ujtavf.nev = lekerdezetttavf[i];
                    ujtavf.sebzes = lekerdezettseb[i];
                    lekerdezettfv.Add(ujtavf);
                }
                Assert.AreEqual(elvartfegyv.Count, lekerdezettfv.Count);
                for (int i = 0; i < elvartfegyv.Count; i++)
                {
                    Assert.AreEqual(elvartfegyv[i].nev, lekerdezettfv[i].nev);
                    Assert.AreEqual(elvartfegyv[i].sebzes, lekerdezettfv[i].sebzes);
                }
            }

        }

        [TestMethod()]
        public void MagFegyverLekerdezTest()
        {
            FegyverAdatbazis fegy = FegyverAdatbazis.getInstance();
            List<MagikusF> elvartfegyv = new List<MagikusF>();
            List<string> elvartmagfegyverek = new List<string>();
            List<int> elvartsebzesek = new List<int>();
            elvartmagfegyverek.Add("tűz botja");
            elvartmagfegyverek.Add("jég botja");
            elvartmagfegyverek.Add("szél botja");
            elvartmagfegyverek.Add("föld botja");
            elvartmagfegyverek.Add("káosz gömbje");
            elvartmagfegyverek.Add("éjtalizmán");
            elvartsebzesek.Add(300);
            elvartsebzesek.Add(300);
            elvartsebzesek.Add(300);
            elvartsebzesek.Add(300);
            elvartsebzesek.Add(350);
            elvartsebzesek.Add(250);
            for (int i = 0; i < elvartmagfegyverek.Count; i++)
            {
                MagikusF magf = new MagikusF();
                magf.nev = elvartmagfegyverek[i];
                magf.sebzes = elvartsebzesek[i];
                elvartfegyv.Add(magf);
            }

            List<MagikusF> lekerdezettfv = new List<MagikusF>();
            List<string> lekerdezettmagf = new List<string>();
            List<int> lekerdezettseb = new List<int>();
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

                        lekerdezettmagf.Add((string)reader[0]);
                        lekerdezettseb.Add(int.Parse(reader[1].ToString()));
                    }
                    reader.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                for (int i = 0; i < lekerdezettmagf.Count; i++)
                {
                    MagikusF ujmagf = new MagikusF();
                    ujmagf.nev = lekerdezettmagf[i];
                    ujmagf.sebzes = lekerdezettseb[i];
                    lekerdezettfv.Add(ujmagf);
                }
                Assert.AreEqual(elvartfegyv.Count, lekerdezettfv.Count);
                for (int i = 0; i < elvartfegyv.Count; i++)
                {
                    Assert.AreEqual(elvartfegyv[i].nev, lekerdezettfv[i].nev);
                    Assert.AreEqual(elvartfegyv[i].sebzes, lekerdezettfv[i].sebzes);
                }
            }
        }
    }
}