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
        public Ujjatek(string a)
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
