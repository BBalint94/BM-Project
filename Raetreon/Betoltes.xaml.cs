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
    /// Interaction logic for Betoltes.xaml
    /// </summary>
    public partial class Betoltes : Window
    {        
        private static Betoltes uniqueInstance = null;
        private Betoltes() { }
        public static Betoltes getInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new Betoltes();
            return uniqueInstance;

        }

        static KarakterAdatbazis karadatb = KarakterAdatbazis.getInstance();
        static KarakterRaktar karakterek = KarakterRaktar.getInstance();
        static GlobalClass gc = GlobalClass.getInstance();
        static List<Harcos> h_karakterek = karadatb.JatHarcosLekerdez();
        static List<Magus> m_karakterek = karadatb.JatMagusLekerdez();
        static List<Ijasz> i_karakterek = karadatb.JatIjaszLekerdez();        
        

        public Betoltes(string a)
        {
            InitializeComponent();
            this.ShowDialog();            
        }
        public void AblakMegjelenit()
        {
            InitializeComponent();
            if (!kaszt_valaszt.Items.Contains("Harcos") || !kaszt_valaszt.Items.Contains("Mágus") || !kaszt_valaszt.Items.Contains("Íjász"))
            {
                kaszt_valaszt.Items.Add("Harcos");
                kaszt_valaszt.Items.Add("Mágus");
                kaszt_valaszt.Items.Add("Íjász");
            }
            this.Show();            
        }

        private void visszalep_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            InitializeComponent();
            mw.Show();
            this.Hide();
        }

        private void kasztvalbutton_Click(object sender, RoutedEventArgs e)
        {
            int tartszam = karakter_valaszto.Items.Count;
            if (kaszt_valaszt.Items.IndexOf(kaszt_valaszt.SelectedItem) == 0)
            {
                for (int i = 0; i < tartszam; i++)
                {
                    karakter_valaszto.Items.RemoveAt(karakter_valaszto.Items.IndexOf(karakter_valaszto.Items[0]));
                }
                for (int i = 0; i < h_karakterek.Count; i++)
                {
                    karakter_valaszto.Items.Add(h_karakterek[i].nev);
                }                
                
            }
            else if (kaszt_valaszt.Items.IndexOf(kaszt_valaszt.SelectedItem) == 1)
            {
                for (int i = 0; i < tartszam; i++)
                {
                    karakter_valaszto.Items.RemoveAt(karakter_valaszto.Items.IndexOf(karakter_valaszto.Items[0]));
                }
                for (int i = 0; i < m_karakterek.Count; i++)
                {
                    karakter_valaszto.Items.Add(m_karakterek[i].nev);
                }                

            }
            else if (kaszt_valaszt.Items.IndexOf(kaszt_valaszt.SelectedItem) == 2)
            {

                for (int i = 0; i < tartszam; i++)
                {
                    karakter_valaszto.Items.RemoveAt(karakter_valaszto.Items.IndexOf(karakter_valaszto.Items[0]));
                }
                for (int i = 0; i < i_karakterek.Count; i++)
                {
                    karakter_valaszto.Items.Add(i_karakterek[i].nev);
                }                
            }
            else
            {
                MessageBox.Show("Válassz kasztot!");
            }
        }

        private void kivalaszt_Click(object sender, RoutedEventArgs e)
        {
            if (kaszt_valaszt.Items.IndexOf(kaszt_valaszt.SelectedItem) == 0 && karakter_valaszto.Items.IndexOf(karakter_valaszto.SelectedItem).ToString() != null)
            {
                try
                {
                    
                    gc.korabbiharcos = h_karakterek[karakter_valaszto.Items.IndexOf(karakter_valaszto.SelectedItem)];
                    Harcter harcter = Harcter.getInstance();
                    harcter.AblakMegjelenit();
                }
                catch
                {
                    MessageBox.Show("Adjon meg minden adatot!");
                }
            }
            else if (kaszt_valaszt.Items.IndexOf(kaszt_valaszt.SelectedItem) == 1 && karakter_valaszto.Items.IndexOf(karakter_valaszto.SelectedItem).ToString() != null)
            {
                try
                {                    
                    gc.korabbimagus = m_karakterek[karakter_valaszto.Items.IndexOf(karakter_valaszto.SelectedItem)];
                    Harcter harcter = Harcter.getInstance();
                    harcter.AblakMegjelenit();

                }
                catch
                {
                    MessageBox.Show("Adjon meg minden adatot!");
                }
            }
            else if (kaszt_valaszt.Items.IndexOf(kaszt_valaszt.SelectedItem) == 2 && karakter_valaszto.Items.IndexOf(karakter_valaszto.SelectedItem).ToString() != null)
            {
                try
                {                   
                    gc.korabbiijasz = i_karakterek[karakter_valaszto.Items.IndexOf(karakter_valaszto.SelectedItem)];
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
    }
 }

