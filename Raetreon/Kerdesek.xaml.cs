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
    /// Interaction logic for Kerdesek.xaml
    /// </summary>
    public partial class Kerdesek : Window
    {
        static KerdesAdatbazis kerdadatb = KerdesAdatbazis.getInstance();
        static KerdesRaktar kerdrakt = KerdesRaktar.getInstance();
        static Random rnd = new Random();
        static string jovalasz;
        static int kerdszam;        

        public Kerdesek()
        {
            InitializeComponent();
            kerdrakt.kerdesek = kerdadatb.KerdesLekerdez();
            kerdrakt.valaszok = kerdadatb.ValaszLekerdez();
            kerdszam = rnd.Next(0, kerdadatb.KerdesLekerdez().Count());
            kerdes.Text = kerdrakt.kerdesek[kerdszam];            
        }

        private void ellenoriz_Click(object sender, RoutedEventArgs e)
        {
            jovalasz = kerdrakt.valaszok[kerdszam];
            if (valaszhelye.Text == jovalasz)
            {
                this.DialogResult = true;
            }
           else
            {
                this.DialogResult = false;
            }
        }
    }
}
