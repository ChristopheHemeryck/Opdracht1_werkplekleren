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

namespace Opdracht1_werkplekleren
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int iNumber = 0;

        private void btnPush_Click(object sender, RoutedEventArgs e)
        {
            if (iNumber == 0)
            {
                txtInput.Text = "Hello world";
            }
            else
            {
                txtInput.Text = "You are wrong";
            }

            iNumber++;
            lblContent.Content = iNumber;
            //
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            lblContent.Content = iNumber;
        }
    }
}
