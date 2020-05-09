using MyApplication.View;
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
using MyApplication.Model;

namespace MyApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Podaci podaci;
        public MainWindow()
        {
            podaci = new Podaci();
            InitializeComponent();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }

        private void NovaTemaBtn_Click(object sender, RoutedEventArgs e)
        {
            FormaTema forma = new FormaTema();
            forma.ShowDialog();
        }
      /*  private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UserControl usc = null;
            GridMain.Children.Clear();

            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "Item1":
                    usc = new UserControlHome();
                    GridMain.Children.Add(usc);
                    break;
                case "Item2":
                    usc = new UserControlCreate();
                    GridMain.Children.Add(usc);
                    break;
                default:
                    break;
            }
        }*/

        private void OdjaviSe_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void OdjaviSe_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Logovanje login = new Logovanje();
            this.Close();
            login.Show();
        }

        private void Item1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            FormaGuestNalog formaGuestNalog = new FormaGuestNalog(podaci);
            formaGuestNalog.ShowDialog();
        }

        private void noviJezikBtn_Click(object sender, RoutedEventArgs e)
        {
            FormaJezik forma = new FormaJezik();
            forma.ShowDialog();
        }

        /*

        private void Item1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            FormaGuestNalog formaGuestNalog = new FormaGuestNalog(podaci);
            formaGuestNalog.ShowDialog();
        }*/
    }
}
