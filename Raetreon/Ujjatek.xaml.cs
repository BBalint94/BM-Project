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
    /// Interaction logic for Ujjatek.xaml
    /// </summary>
    public partial class Ujjatek : Window
    {
        private static Ujjatek uniqueInstance = null;
        private Ujjatek() { }
        public static Ujjatek getInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new Ujjatek();
            return uniqueInstance;

        }

        static FegyverAdatbazis fa = FegyverAdatbazis.getInstance();
        static List<KozelharciF> khf = fa.KhFegyverLekerdez();
        static List<MagikusF> magf = fa.MagFegyverLekerdez();
        static List<TavolsagiF> tavf = fa.TavFegyverLekerdez();
        static KarakterRaktar karakterek = KarakterRaktar.getInstance();
        static KarakterAdatbazis karad = KarakterAdatbazis.getInstance();
        static KepAdatbazis kepadatb = KepAdatbazis.getInstance();
        static List<string> harcoskepek = kepadatb.HarcosKepLekerdez();
        static List<string> ijaszkepek = kepadatb.IjaszKepLekerdez();
        static List<string> maguskepek = kepadatb.MagusKepLekerdez();
        static List<string> osszkep;
        static int szamlalo = 0;        

        public Ujjatek(string a)
        {
            InitializeComponent();            
            this.ShowDialog();           
        }
        public void AblakMegjelenit()
        {
            InitializeComponent();
            if(!kasztvalaszto.Items.Contains("Harcos") || !kasztvalaszto.Items.Contains("Mágus") || !kasztvalaszto.Items.Contains("Íjász"))
            {
                kasztvalaszto.Items.Add("Harcos");
                kasztvalaszto.Items.Add("Mágus");
                kasztvalaszto.Items.Add("Íjász");
            }            
            this.Show();                        
        }

        public void KepKirak(string cim)
        {
            karakterkep.Source = new BitmapImage(new Uri(cim, UriKind.Relative));
            karakterkep.Width = 250;
            karakterkep.Height = 280;

        }

        private void visszalep_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            InitializeComponent();
            mw.Show();
            this.Hide();
        }

        private void letrehoz_Click(object sender, RoutedEventArgs e)
        {
            if (kasztvalaszto.Items.IndexOf(kasztvalaszto.SelectedItem) == 0 && karakternev.Text != null)
            {
                try
                {
                    string eredetikep = karakterkep.Source.ToString();
                    string keszkep = eredetikep.Remove(0, 41);
                    //string kepkivon = "pack://application:,,,/Raetreon;component/";
                    string fegyver = fegyvervalaszto.Items[fegyvervalaszto.Items.IndexOf(fegyvervalaszto.SelectedItem)].ToString();
                    karakterek.kivantkaszt = 0;
                    karad.JatHarcosFeltolt(karakternev.Text, "Harcos", fegyvervalaszto.Items[fegyvervalaszto.Items.IndexOf(fegyvervalaszto.SelectedItem)].ToString(),keszkep);
                    Harcter harcter = Harcter.getInstance();
                    harcter.AblakMegjelenit();
                }
                catch
                {                    
                    MessageBox.Show("Adjon meg minden adatot!");
                }
            }
            else if (kasztvalaszto.Items.IndexOf(kasztvalaszto.SelectedItem) == 1 && karakternev.Text != null)
            {
                try
                {
                    string eredetikep = karakterkep.Source.ToString();
                    string keszkep = eredetikep.Remove(0, 41);
                    string fegyver = fegyvervalaszto.Items[fegyvervalaszto.Items.IndexOf(fegyvervalaszto.SelectedItem)].ToString();
                    karakterek.kivantkaszt = 1;
                    karad.JatMagusFeltolt(karakternev.Text, "Mágus", fegyvervalaszto.Items[fegyvervalaszto.Items.IndexOf(fegyvervalaszto.SelectedItem)].ToString(), keszkep);
                    Harcter harcter = Harcter.getInstance();
                    harcter.AblakMegjelenit();

                }
                catch
                {
                    MessageBox.Show("Adjon meg minden adatot!");
                }
            }
            else if (kasztvalaszto.Items.IndexOf(kasztvalaszto.SelectedItem) == 2 && karakternev.Text != null)
            {
                try
                {
                    string eredetikep = karakterkep.Source.ToString();
                    string keszkep = eredetikep.Remove(0, 41);
                    string fegyver = fegyvervalaszto.Items[fegyvervalaszto.Items.IndexOf(fegyvervalaszto.SelectedItem)].ToString();
                    karakterek.kivantkaszt = 2;
                    karad.JatIjaszFeltolt(karakternev.Text, "Íjász", fegyvervalaszto.Items[fegyvervalaszto.Items.IndexOf(fegyvervalaszto.SelectedItem)].ToString(), keszkep);
                    Harcter harcter = Harcter.getInstance();
                    harcter.AblakMegjelenit();

                }
                catch
                {
                    MessageBox.Show("Adjon meg minden adatot!");
                }
            }
            else
            {
                MessageBox.Show("Adja meg a kért adatokat!");
            }
        }
    

        private void kivalaszt_kaszt_Click(object sender, RoutedEventArgs e)
        {            
            int tartszam = fegyvervalaszto.Items.Count;
            if (kasztvalaszto.Items.IndexOf(kasztvalaszto.SelectedItem) == 0)
            {
                for (int i = 0; i < tartszam; i++)
                {
                    fegyvervalaszto.Items.RemoveAt(fegyvervalaszto.Items.IndexOf(fegyvervalaszto.Items[0]));
                }
                for (int i = 0; i < khf.Count; i++)
                {
                    fegyvervalaszto.Items.Add(khf[i].nev);
                }
                KepKirak(harcoskepek[0]);
                osszkep = harcoskepek;
                szamlalo = 0;
            }
            else if (kasztvalaszto.Items.IndexOf(kasztvalaszto.SelectedItem) == 1)
            {
                for (int i = 0; i < tartszam; i++)
                {
                    fegyvervalaszto.Items.RemoveAt(fegyvervalaszto.Items.IndexOf(fegyvervalaszto.Items[0]));
                }
                for (int i = 0; i < magf.Count; i++)
                {
                    fegyvervalaszto.Items.Add(magf[i].nev);
                }
                KepKirak(maguskepek[0]);
                osszkep = maguskepek;
                szamlalo = 0;
                
            }
            else if (kasztvalaszto.Items.IndexOf(kasztvalaszto.SelectedItem) == 2)
            {

                for (int i = 0; i < tartszam; i++)
                {
                    fegyvervalaszto.Items.RemoveAt(fegyvervalaszto.Items.IndexOf(fegyvervalaszto.Items[0]));
                }
                for (int i = 0; i < tavf.Count; i++)
                {
                    fegyvervalaszto.Items.Add(tavf[i].nev);
                }
                KepKirak(ijaszkepek[0]);
                osszkep = ijaszkepek;
                szamlalo = 0;
            }
            else
            {
                MessageBox.Show("Válassz kasztot!");
            }
        }

        private void bnyil_Click(object sender, RoutedEventArgs e)
        {
            if (osszkep != null)
            {
                if (szamlalo > 0)
                {
                    szamlalo--;
                    KepKirak(osszkep[szamlalo]);
                }
                else
                {
                    szamlalo = osszkep.Count - 1;
                    KepKirak(osszkep[szamlalo]);
                }
            }
            
        }

        private void jnyil_Click(object sender, RoutedEventArgs e)
        {
            if (osszkep != null)
            {
                if (szamlalo < osszkep.Count - 1)
                {
                    szamlalo++;
                    KepKirak(osszkep[szamlalo]);
                }
                else
                {
                    szamlalo = 0;
                    KepKirak(osszkep[szamlalo]);
                }
            }
        }
    }
}
