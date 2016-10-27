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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Raetreon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
                
        public MainWindow()
        {

            InitializeComponent();
        }

        private void ujjatek_Click(object sender, RoutedEventArgs e)
        {
            Ujjatek uj = Ujjatek.getInstance();
            uj.AblakMegjelenit();
            this.Close();
        }

        private void betolt_Click(object sender, RoutedEventArgs e)
        {
            Betoltes be = Betoltes.getInstance();
            be.AblakMegjelenit();
            this.Close();
        }

        private void kilepes_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
