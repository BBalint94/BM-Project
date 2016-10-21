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
        public Betoltes(string a)
        {
            InitializeComponent();
            this.ShowDialog();
        }
        public void AblakMegjelenit()
        {
            InitializeComponent();
            this.Show();            
        }

        private void visszalep_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            InitializeComponent();
            mw.Show();
            this.Hide();
        }
    }
 }

