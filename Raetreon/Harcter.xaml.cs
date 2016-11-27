using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Raetreon
{
    /// <summary>
    /// Interaction logic for Harcter.xaml
    /// </summary>
    public partial class Harcter : Window
    {
        private static Harcter uniqueInstance = null;
        private Harcter() { }
        public static Harcter getInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new Harcter();
            return uniqueInstance;

        }
        static KarakterRaktar karakter = KarakterRaktar.getInstance();
        static KarakterAdatbazis karad = KarakterAdatbazis.getInstance();
        static EllensegRaktar ellensegek = EllensegRaktar.getInstance();
        static EllensegAdatbazis elladatb = EllensegAdatbazis.getInstance();
        static GlobalClass gc = GlobalClass.getInstance();
        static Random rnd = new Random();
        static Harcos harcosunk;
        static Harcos korharcos = gc.korabbiharcos;       
        static Ellenseg ellenseg;
        static Magus magusunk;
        static Magus kormagus = gc.korabbimagus;        
        static Ijasz ijaszunk;
        static Ijasz korijasz = gc.korabbiijasz;        
        static bool vegevane = false;
        static Esemenykozlo ek = new Esemenykozlo();
        static Hirdeto hirnok = new Hirdeto("Hírnök");
        static int korokszama = 1;

        public Harcter(string a)
        {
            InitializeComponent();
            this.ShowDialog();
        }
        public void AblakMegjelenit()
        {
            InitializeComponent();
            this.Show();
            if(korharcos.nev !=null || kormagus.nev!=null || korijasz.nev!= null)
            {
                KorabbiJatekosBetolt();
            }else
            {
                JatekosBetolt();
            }            
            EllensegBetolt();
        }

        public void KepKirak(string cim)
        {
            kepunk.Source = new BitmapImage(new Uri(cim, UriKind.Relative));
            kepunk.Width = 250;
            kepunk.Height = 280;

        }
        public void EllenKepKirak(string cim)
        {
            ellenkep.Source = new BitmapImage(new Uri(cim, UriKind.Relative));
            ellenkep.Width = 250;
            ellenkep.Height = 280;
        }
        public void JatekosBetolt()
        {
            if (karakter.kivantkaszt == 0)
            {
                List<Harcos> lekharcosok = karad.JatHarcosLekerdez();
                Harcos jharcos = new Harcos();
                jharcos.nev = lekharcosok[lekharcosok.Count - 1].nev;
                jharcos.maxeletero = lekharcosok[lekharcosok.Count - 1].maxeletero;
                jharcos.eletero = lekharcosok[lekharcosok.Count - 1].eletero;
                jharcos.harcosfegyver = lekharcosok[lekharcosok.Count - 1].harcosfegyver;
                jharcos.kep = lekharcosok[lekharcosok.Count - 1].kep;                
                harcosunk = jharcos;                
            }
            else if (karakter.kivantkaszt == 1)
            {
                List<Magus> lekmagusok = karad.JatMagusLekerdez();
                Magus jmagus = new Magus();
                jmagus.nev = lekmagusok[lekmagusok.Count - 1].nev;
                jmagus.maxeletero = lekmagusok[lekmagusok.Count - 1].maxeletero;
                jmagus.eletero = lekmagusok[lekmagusok.Count - 1].eletero;
                jmagus.magusfegyver = lekmagusok[lekmagusok.Count - 1].magusfegyver;
                jmagus.kep = lekmagusok[lekmagusok.Count - 1].kep;
                magusunk = jmagus;                
            }
            else if (karakter.kivantkaszt == 2)
            {
                List<Ijasz> lekijaszok = karad.JatIjaszLekerdez();
                Ijasz jijasz = new Ijasz();
                jijasz.nev = lekijaszok[lekijaszok.Count - 1].nev;
                jijasz.maxeletero = lekijaszok[lekijaszok.Count - 1].maxeletero;
                jijasz.eletero = lekijaszok[lekijaszok.Count - 1].eletero;
                jijasz.ijaszfegyver = lekijaszok[lekijaszok.Count - 1].ijaszfegyver;
                jijasz.kep = lekijaszok[lekijaszok.Count - 1].kep;
                ijaszunk = jijasz;               
            }
            else throw new Exception("Nincs ilyen kaszt!");

            if (harcosunk != null)
            {
                karakternev.Content = harcosunk.nev;
                jatekoseletero.Content = harcosunk.eletero;
                jatkasztja.Content = "Harcos";
                jatfegyvere.Content = harcosunk.harcosfegyver.nev;
                KepKirak(harcosunk.kep);
            }
            else if (magusunk != null)
            {
                karakternev.Content = magusunk.nev;
                jatekoseletero.Content = magusunk.eletero;
                jatkasztja.Content = "Mágus";
                jatfegyvere.Content = magusunk.magusfegyver.nev.ToString();
                KepKirak(magusunk.kep);
            }
            else if (ijaszunk != null)
            {
                karakternev.Content = ijaszunk.nev;
                jatekoseletero.Content = ijaszunk.eletero;
                jatkasztja.Content = "Íjász";
                jatfegyvere.Content = ijaszunk.ijaszfegyver.nev;
                KepKirak(ijaszunk.kep);
            }
            else throw new Exception("Hiba");

        }
        public void KorabbiJatekosBetolt()
        {
            if (karakter.kivantkaszt == 0)
            {
                //List<Harcos> lekharcosok = karad.JatHarcosLekerdez();
                //Harcos jharcos = korharcos;
                /*jharcos.nev = lekharcosok[lekharcosok.Count - 1].nev;
                jharcos.maxeletero = lekharcosok[lekharcosok.Count - 1].maxeletero;
                jharcos.eletero = lekharcosok[lekharcosok.Count - 1].eletero;
                jharcos.harcosfegyver = lekharcosok[lekharcosok.Count - 1].harcosfegyver;
                jharcos.kep = lekharcosok[lekharcosok.Count - 1].kep; */
                harcosunk = korharcos;
            }
            else if (karakter.kivantkaszt == 1)
            {
                //List<Magus> lekmagusok = karad.JatMagusLekerdez();
                //Magus jmagus = GlobalClass.korabbimagus;
                /*jmagus.nev = lekmagusok[lekmagusok.Count - 1].nev;
                jmagus.maxeletero = lekmagusok[lekmagusok.Count - 1].maxeletero;
                jmagus.eletero = lekmagusok[lekmagusok.Count - 1].eletero;
                jmagus.magusfegyver = lekmagusok[lekmagusok.Count - 1].magusfegyver;
                jmagus.kep = lekmagusok[lekmagusok.Count - 1].kep; */
                magusunk = kormagus;
            }
            else if (karakter.kivantkaszt == 2)
            {
                //List<Ijasz> lekijaszok = karad.JatIjaszLekerdez();
                //Ijasz jijasz = GlobalClass.korabbiijasz;
                /*jijasz.nev = lekijaszok[lekijaszok.Count - 1].nev;
                jijasz.maxeletero = lekijaszok[lekijaszok.Count - 1].maxeletero;
                jijasz.eletero = lekijaszok[lekijaszok.Count - 1].eletero;
                jijasz.ijaszfegyver = lekijaszok[lekijaszok.Count - 1].ijaszfegyver;
                jijasz.kep = lekijaszok[lekijaszok.Count - 1].kep; */
                ijaszunk = korijasz;
            }
            else throw new Exception("Nincs ilyen kaszt!");

            if (korharcos.nev != null)
            {
                karakternev.Content = korharcos.nev;
                jatekoseletero.Content = korharcos.eletero;
                jatkasztja.Content = "Harcos";
                jatfegyvere.Content = korharcos.harcosfegyver.nev;
                KepKirak(korharcos.kep);
            }
            else if (kormagus.nev != null)
            {
                karakternev.Content = kormagus.nev;
                jatekoseletero.Content = kormagus.eletero;
                jatkasztja.Content = "Mágus";
                jatfegyvere.Content = kormagus.magusfegyver.nev.ToString();
                KepKirak(kormagus.kep);
            }
            else if (korijasz.nev != null)
            {
                karakternev.Content = korijasz.nev;
                jatekoseletero.Content = korijasz.eletero;
                jatkasztja.Content = "Íjász";
                jatfegyvere.Content = korijasz.ijaszfegyver.nev;
                KepKirak(korijasz.kep);
            }
            else throw new Exception("Hiba");

        }
        public void EllensegBetolt()
        {
            List<Ellenseg> ellensegek = elladatb.EllensegLekerdez();
            ellenseg = ellensegek[rnd.Next(0, ellensegek.Count)];

            if (ellenseg != null)
            {
                ellennev.Content = ellenseg.nev;
                ellensegeletero.Content = ellenseg.eletero;
                ellenkasztja.Content = ellenseg.kaszt;
                ellenfegyvere.Content = ellenseg.ellenfegyver.nev;
                //ellenseg.kep = ellensegek[ellensegek.Count - 1].kep;
                ellenseg.kep = "Images/Ellenseg/ellenseg3.png";
                EllenKepKirak(ellenseg.kep);
            }            
            else throw new Exception("Hiba");
        }
        public void Harc()
        {
            int helete;
            int heletu;
            int eelete;
            int eeletu;
            int szenv;
            int okoz;
            if (harcosunk != null)
            {
                if (ellenseg != null)
                {
                    helete = harcosunk.eletero;
                    eelete = ellenseg.eletero;
                    harcosunk.Tamad(ellenseg, harcosunk.harcosfegyver);
                    ellenseg.Tamad(harcosunk, ellenseg.ellenfegyver);
                    heletu = harcosunk.eletero;
                    eeletu = ellenseg.eletero;
                    okoz = eelete - eeletu;
                    szenv = helete - heletu;
                    jatekoseletero.Content = harcosunk.eletero;
                    ellensegeletero.Content = ellenseg.eletero;
                    hirnok.update(korokszama, okoz, szenv, vegevane);
                    korokszama++;
                    if (harcosunk.harckeptelen == true && ellenseg.harckeptelen == false)
                    {
                        MessageBox.Show("Vesztettél!");
                        vegevane = true;
                        hirnok.update(korokszama, okoz, szenv, vegevane);
                    }
                    if (ellenseg.harckeptelen == true && harcosunk.harckeptelen == false)
                    {
                        MessageBox.Show("Nyertél!");
                        vegevane = true;
                        hirnok.update(korokszama, okoz, szenv, vegevane);
                    }
                    if (harcosunk.harckeptelen == true && ellenseg.harckeptelen == true)
                    {
                        MessageBox.Show("Döntetlen!");
                        vegevane = true;
                        hirnok.update(korokszama, okoz, szenv, vegevane);
                    }               
                }
                else throw new Exception("Nincs ellenfél!");
            }
            else if (magusunk != null)
            {
                if (ellenseg != null)
                {
                    helete = magusunk.eletero;
                    eelete = ellenseg.eletero;
                    magusunk.Tamad(ellenseg, magusunk.magusfegyver);
                    ellenseg.Tamad(magusunk, ellenseg.ellenfegyver);
                    heletu = magusunk.eletero;
                    eeletu = ellenseg.eletero;
                    okoz = eelete - eeletu;
                    szenv = helete - heletu;
                    jatekoseletero.Content = magusunk.eletero;
                    ellensegeletero.Content = ellenseg.eletero;
                    hirnok.update(korokszama, okoz, szenv, vegevane);
                    korokszama++;
                    if (magusunk.harckeptelen == true && ellenseg.harckeptelen == false)
                    {
                        MessageBox.Show("Vesztettél!");
                        vegevane = true;
                        hirnok.update(korokszama, okoz, szenv, vegevane);
                    }
                    if (ellenseg.harckeptelen == true && magusunk.harckeptelen == false)
                    {
                        MessageBox.Show("Nyertél!");
                        vegevane = true;
                        hirnok.update(korokszama, okoz, szenv, vegevane);
                    }
                    if (magusunk.harckeptelen == true && ellenseg.harckeptelen == true)
                    {
                        MessageBox.Show("Döntetlen!");
                        vegevane = true;
                        hirnok.update(korokszama, okoz, szenv, vegevane);
                    }
                }                
                else throw new Exception("Nincs ellenfél!");

            }
            else if (ijaszunk != null)
            {
                if (ellenseg != null)
                {
                    helete = ijaszunk.eletero;
                    eelete = ellenseg.eletero;
                    ijaszunk.Tamad(ellenseg, ijaszunk.ijaszfegyver);
                    ellenseg.Tamad(ijaszunk, ellenseg.ellenfegyver);
                    heletu = ijaszunk.eletero;
                    eeletu = ellenseg.eletero;
                    okoz = eelete - eeletu;
                    szenv = helete - heletu;
                    jatekoseletero.Content = ijaszunk.eletero;
                    ellensegeletero.Content = ellenseg.eletero;
                    hirnok.update(korokszama, okoz, szenv, vegevane);
                    korokszama++;
                    if (ijaszunk.harckeptelen == true && ellenseg.harckeptelen == false)
                    {
                        MessageBox.Show("Vesztettél!");
                        vegevane = true;
                        hirnok.update(korokszama, okoz, szenv, vegevane);
                    }
                    if (ellenseg.harckeptelen == true && ijaszunk.harckeptelen == false)
                    {
                        MessageBox.Show("Nyertél!");
                        vegevane = true;
                        hirnok.update(korokszama, okoz, szenv, vegevane);
                    }
                    if (ijaszunk.harckeptelen == true && ellenseg.harckeptelen == true)
                    {
                        MessageBox.Show("Döntetlen!");
                        vegevane = true;
                        hirnok.update(korokszama, okoz, szenv, vegevane);
                    }
                }                
                else throw new Exception("Nincs ellenfél!");

            }
            else throw new Exception("Nincs játékos!");
        }

        public void Vedekezes()
        {
            int helete;
            int heletu;
            int eelete;
            int eeletu;
            int szenv;
            int okoz;
            if (harcosunk != null)
            {
                if (ellenseg != null)
                {
                    helete = harcosunk.eletero;
                    eelete = ellenseg.eletero;
                    harcosunk.Vedekez(harcosunk, ellenseg.ellenfegyver);
                    ellenseg.Tamad(harcosunk, ellenseg.ellenfegyver);
                    heletu = harcosunk.eletero;
                    eeletu = ellenseg.eletero;
                    okoz = eelete - eeletu;
                    szenv = helete - heletu;
                    jatekoseletero.Content = harcosunk.eletero;
                    ellensegeletero.Content = ellenseg.eletero;
                    hirnok.update(korokszama, okoz, szenv, vegevane);
                    korokszama++;
                    if (harcosunk.harckeptelen == true && ellenseg.harckeptelen == false)
                    {
                        MessageBox.Show("Vesztettél!");
                        vegevane = true;
                        hirnok.update(korokszama, okoz, szenv, vegevane);
                    }
                    if (ellenseg.harckeptelen == true && harcosunk.harckeptelen == false)
                    {
                        MessageBox.Show("Nyertél!");
                        vegevane = true;
                        hirnok.update(korokszama, okoz, szenv, vegevane);
                    }
                    if (harcosunk.harckeptelen == true && ellenseg.harckeptelen == true)
                    {
                        MessageBox.Show("Döntetlen!");
                        vegevane = true;
                        hirnok.update(korokszama, okoz, szenv, vegevane);
                    }
                }
                else throw new Exception("Nincs ellenfél!");
            }
            else if (magusunk != null)
            {
                if (ellenseg != null)
                {
                    helete = magusunk.eletero;
                    eelete = ellenseg.eletero;
                    magusunk.Tamad(magusunk, ellenseg.ellenfegyver);
                    ellenseg.Tamad(magusunk, ellenseg.ellenfegyver);
                    heletu = magusunk.eletero;
                    eeletu = ellenseg.eletero;
                    okoz = eelete - eeletu;
                    szenv = helete - heletu;
                    jatekoseletero.Content = magusunk.eletero;
                    ellensegeletero.Content = ellenseg.eletero;
                    hirnok.update(korokszama, okoz, szenv, vegevane);
                    korokszama++;
                    if (magusunk.harckeptelen == true && ellenseg.harckeptelen == false)
                    {
                        MessageBox.Show("Vesztettél!");
                        vegevane = true;
                        hirnok.update(korokszama, okoz, szenv, vegevane);
                    }
                    if (ellenseg.harckeptelen == true && magusunk.harckeptelen == false)
                    {
                        MessageBox.Show("Nyertél!");
                        vegevane = true;
                        hirnok.update(korokszama, okoz, szenv, vegevane);
                    }
                    if (magusunk.harckeptelen == true && ellenseg.harckeptelen == true)
                    {
                        MessageBox.Show("Döntetlen!");
                        vegevane = true;
                        hirnok.update(korokszama, okoz, szenv, vegevane);
                    }
                }
                else throw new Exception("Nincs ellenfél!");

            }
            else if (ijaszunk != null)
            {
                if (ellenseg != null)
                {
                    helete = ijaszunk.eletero;
                    eelete = ellenseg.eletero;
                    ijaszunk.Tamad(ijaszunk, ellenseg.ellenfegyver);
                    ellenseg.Tamad(ijaszunk, ellenseg.ellenfegyver);
                    heletu = ijaszunk.eletero;
                    eeletu = ellenseg.eletero;
                    okoz = eelete - eeletu;
                    szenv = helete - heletu;
                    jatekoseletero.Content = ijaszunk.eletero;
                    ellensegeletero.Content = ellenseg.eletero;
                    hirnok.update(korokszama, okoz, szenv, vegevane);
                    korokszama++;
                    if (ijaszunk.harckeptelen == true && ellenseg.harckeptelen == false)
                    {
                        MessageBox.Show("Vesztettél!");
                        vegevane = true;
                        hirnok.update(korokszama, okoz, szenv, vegevane);
                    }
                    if (ellenseg.harckeptelen == true && ijaszunk.harckeptelen == false)
                    {
                        MessageBox.Show("Nyertél!");
                        vegevane = true;
                        hirnok.update(korokszama, okoz, szenv, vegevane);
                    }
                    if (ijaszunk.harckeptelen == true && ellenseg.harckeptelen == true)
                    {
                        MessageBox.Show("Döntetlen!");
                        vegevane = true;
                        hirnok.update(korokszama, okoz, szenv, vegevane);
                    }
                }
                else throw new Exception("Nincs ellenfél!");

            }
            else throw new Exception("Nincs játékos!");
        }

        private void tamadas_Click(object sender, RoutedEventArgs e)
        {
            if (vegevane == true)
            {
                MessageBox.Show("A játéknak vége! Kattints a kilépésre!");
            }
            else
            {
                Harc();
            }
        }

        private void kilepes_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void vedekezes_Click(object sender, RoutedEventArgs e)
        {
            if(vegevane == true)
            {
                MessageBox.Show("A játéknak vége! Kattints a kilépésre!");
            }
            else
            {
                Vedekezes();
            }
        }
    }
}
