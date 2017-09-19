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
        public FrmDobbelsteen()
        {
            InitializeComponent();
        }

        private void btnGooien_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();

            lblGetal1.Content = random.Next();
            lblGetal2.Content = random.Next();
        }
    }
}
