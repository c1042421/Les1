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

namespace oefDobbelstenen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class FrmDobbelsteen : Window
    {
        Random random;
        Dobbelsteen steen1;
        Dobbelsteen steen2;

        public FrmDobbelsteen()
        {
            InitializeComponent();
        }

        public void Window_Loaded(object sender, RoutedEventArgs e)
        {
            random = new Random();

            steen1 = new Dobbelsteen(random);
            steen2 = new Dobbelsteen(4, random);
        }

        private void btnGooien_Click(object sender, RoutedEventArgs e)
        {
            steen1.Roll();
            steen2.Roll();

            lblGetal1.Content = steen1.Waarde;
            lblGetal2.Content = steen2.Waarde;
        }
    }
}
