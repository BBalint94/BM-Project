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

        private void visszalep_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            InitializeComponent();
            mw.Show();
            this.Hide();
        }

        private void letrehoz_Click(object sender, RoutedEventArgs e)
        {

        }

        private void kivalazt_kaszt_Click(object sender, RoutedEventArgs e)
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
            }
        }
    }
}
