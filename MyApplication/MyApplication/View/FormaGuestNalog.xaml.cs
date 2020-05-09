using MyApplication.Model;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MyApplication.View
{
    /// <summary>
    /// Interaction logic for FormaGuestNalog.xaml
    /// </summary>
    public partial class FormaGuestNalog : Window
    {
        private GuestNalog guestNalog;
        private Podaci podaci;
        private bool zatvoriSaPorukom;


        public FormaGuestNalog(Podaci podaci)
        {
            this.podaci = podaci;
            InitializeComponent();
            guestNalog = new GuestNalog();
            this.DataContext = guestNalog;
            txtJmbg.Text = "";
            txtJmbg.Focus();
            txtIme.Text = "";
            txtPrezime.Text = "";
            zatvoriSaPorukom = true;
        }

        private void Kreiraj_Click(object sender, RoutedEventArgs e)
        {



            if (podaci.SviGuestNalozi.ContainsKey(guestNalog.Jmbg))
            {
                MessageBox.Show("Uneti JMBG nije jedinstven. Pokušajte ponovo.", "Upozorenje!",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                txtJmbg.Clear();
                txtJmbg.Focus();
                return;               
            }
            else if (String.IsNullOrEmpty(guestNalog.Ime))
            {
                MessageBox.Show("Polje za ime ne sme ostati prazno.", "Upozorenje!",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                txtIme.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(guestNalog.Prezime))
            {
                MessageBox.Show("Polje za prezime ne sme ostati prazno.", "Upozorenje!",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                txtPrezime.Focus();
                return;
            }
            
            

            podaci.SviGuestNalozi.Add(guestNalog.Jmbg, guestNalog);

            MessageBox.Show("Guest nalog je uspešno dodat.", "Uspeh!",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            zatvoriSaPorukom = false;
            this.Close();
        }
    

        private void Odustani_Click(object sender, RoutedEventArgs e)
        {
            zatvoriSaPorukom = true;
            this.Close();
        }

        private void RegistujSe_Click(object sender, RoutedEventArgs e)
        {
            FormaPraviNalog formaPraviNalog = new FormaPraviNalog(podaci);
            formaPraviNalog.Show();
            this.Close();
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (zatvoriSaPorukom)
            {
                MessageBoxResult result = MessageBox.Show("Da li ste sigurni da želite da odustanete?", "Odustajete?",
                    MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
