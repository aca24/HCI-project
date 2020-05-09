using MyApplication.Model;
using MyApplication.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for Logovanje.xaml
    /// </summary>
    public partial class Logovanje : Window, INotifyPropertyChanged
    {
        private String username;
        private String password;

        public String Username
        {
            get { return username; }
            set
            {
                if (value != username)
                {
                    username = value;
                    OnPropertyChanged("Username");
                }
            }
        }

        public String Password
        {
            get { return password; }
            set
            {
                if (value != password)
                {
                    password = value;
                    OnPropertyChanged("Password");
                }
            }
        }

        protected virtual void OnPropertyChanged(String name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Logovanje()
        {
            InitializeComponent();
            this.DataContext = this;
            txtKorisnickoIme.Focus();
        }

        private void Odustani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Potvrdi_Click(object sender, RoutedEventArgs e)
        {
            UserInfo user = new UserInfo();
            if (String.IsNullOrEmpty(username))
            {
                MessageBox.Show("Morate uneti korisničko ime.", "Upozorenje!",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                txtKorisnickoIme.Focus();
                txtPassword.Clear();
                txtKorisnickoIme.Focus();
                return;
            }
            else if (!user.CheckExistence(username))
            {
                MessageBox.Show("Ne postoji korisnik registrovan sa ovim korisničkim imenom. Ako ste novi korisnik, morate se registovati.",
                    "Upozorenje!", MessageBoxButton.OK, MessageBoxImage.Warning);
                txtKorisnickoIme.Clear();
                txtPassword.Clear();
                txtKorisnickoIme.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Morate uneli lozinku.", "Upozorenje!",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                txtPassword.Focus();
                return;
            }
            else if (!user.FindPasswordMatch(username, password))
            {
                MessageBox.Show("Uneli ste pogrešno korisničko ime/lozinku. Pokušajte ponovo.", "Upozorenje!",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                txtKorisnickoIme.Clear();
                txtKorisnickoIme.Focus();
                txtPassword.Clear();
                return;
            }

            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void RegistujSe_Click(object sender, RoutedEventArgs e)
        {
            Registrovanje registrovanje = new Registrovanje();
            registrovanje.Show();
            this.Close();
        }

        // sprecavanje kopiranja i isecanja polja za password
        private void textBox_PreviewExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Command == ApplicationCommands.Copy ||
                e.Command == ApplicationCommands.Cut ||
                e.Command == ApplicationCommands.Paste)
            {
                e.Handled = true;
            }
        }   
    }
}
