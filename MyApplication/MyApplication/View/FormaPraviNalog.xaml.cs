using MyApplication.Model;
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
    /// Interaction logic for FormaPraviNalog.xaml
    /// </summary>
    public partial class FormaPraviNalog : Window
    {
        private PraviNalog praviNalog;
        private Podaci podaci;
        private bool zavrsiPoruku;

        public FormaPraviNalog(Podaci podaci)
        {
            this.podaci = podaci;
            InitializeComponent();
            praviNalog = new PraviNalog();
            this.DataContext = praviNalog;
            txtJmbg.Text = "";
            txtJmbg.Focus();
            txtIme.Text = "";
            txtPrezime.Text = "";
            txtBroj.Text = "";
            txtEmail.Text = "";
           // dpDatRodjenja.SelectedDate = DateTime.Now;
            dpDatRodjenja.DisplayDateEnd = DateTime.Now;
            zavrsiPoruku = true;
        }

        private void Kreiraj_Click(object sender, RoutedEventArgs e)
        {
            if (podaci.SviPraviNalozi.ContainsKey(praviNalog.Jmbg))
            {
                MessageBox.Show("Uneti JMBG nije jedinstven. Pokušajte ponovo.", "Upozorenje!",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                txtJmbg.Clear();
                txtJmbg.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(praviNalog.Ime))
            {
                MessageBox.Show("Polje za ime ne sme ostati prazno.", "Upozorenje!",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                txtIme.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(praviNalog.Prezime))
            {
                MessageBox.Show("Polje za prezime ne sme ostati prazno.", "Upozorenje!",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                txtPrezime.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(praviNalog.BrojTelefona))
            {
                MessageBox.Show("Polje za broj ne sme ostati prazno.", "Upozorenje!",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                txtBroj.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(praviNalog.Email))
            {
                MessageBox.Show("Polje za email ne sme ostati prazno.", "Upozorenje!",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                txtEmail.Focus();
                return;
            }

            praviNalog.DatumRodjenja = (DateTime)dpDatRodjenja.SelectedDate;

            podaci.SviPraviNalozi.Add(praviNalog.Jmbg, praviNalog);

            MessageBox.Show("Registrovai nalog je uspešno dodat.", "Uspeh!",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            zavrsiPoruku = false;
            this.Close();
        }
        private void Odustani_Click(object sender, RoutedEventArgs e)
        {
            zavrsiPoruku = true;
            this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (zavrsiPoruku)
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
