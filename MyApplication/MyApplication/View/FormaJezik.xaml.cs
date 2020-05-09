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

namespace MyApplication.View
{
    /// <summary>
    /// Interaction logic for FormaJezik.xaml
    /// </summary>
    public partial class FormaJezik : Window
    {
        public FormaJezik()
        {
            InitializeComponent();
        }

        private void Odustani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Potvrdi_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void rb1_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void rb2_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
