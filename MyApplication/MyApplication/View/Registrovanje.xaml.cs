using MyApplication.Model;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace MyApplication.View
{
    /// <summary>
    /// Interaction logic for Registrovanje.xaml
    /// </summary>
    public partial class Registrovanje : Window, INotifyPropertyChanged
    {
        private String username;
        private String password;
        private String passMatch;

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

        public String PassMatch
        {
            get { return passMatch; }
            set
            {
                if (value != passMatch)
                {
                    passMatch = value;
                    OnPropertyChanged("PassMatch");
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

        public Registrovanje()
        {
            InitializeComponent();
            this.DataContext = this;
            txtKorisnickoIme.Focus();
        }

        private void RegistrujSe_Click(object sender, RoutedEventArgs e)
        {
            UserInfo userInfo = new UserInfo();

            if (String.IsNullOrEmpty(username))
            {
                MessageBox.Show("Niste uneli korisničko ime. Pokušajte ponovo.", "Upozorenje!",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                txtKorisnickoIme.Focus();
                txtPassword.Clear();
                txtPassMatch.Clear();
                return;
            }
            else if (userInfo.CheckExistence(username))
            {
                MessageBox.Show("Korisnik sa istim korisničkim imenom već postoji. Izaberite neko drugo korisničko ime.", "Upozorenje!",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                txtKorisnickoIme.Clear();
                txtKorisnickoIme.Focus();
                txtPassword.Clear();
                txtPassMatch.Clear();
                return;
            }
            else if (String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Lozinka ne može biti prazna. Pokušajte ponovo.", "Upozorenje!",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                txtPassword.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(passMatch))
            {
                MessageBox.Show("Morate ponoviti lozinku radi provere.", "Upozorenje!",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                txtPassMatch.Focus();
                return;
            }
            else if (!password.Equals(passMatch))
            {
                MessageBox.Show("Lozinke se ne podudaraju. Pokušajte ponovo.", "Upozorenje!",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                txtPassMatch.Clear();
                txtPassMatch.Focus();
                return;
            }

            MessageBox.Show("Uspešno ste se registrovali! Sada se prijavite da biste pristupili aplikaciji.", "Čestitamo!",
                MessageBoxButton.OK, MessageBoxImage.Information);
            userInfo.RegisterUser(username, password);

            Logovanje logovanje = new Logovanje();
            logovanje.Show();
            this.Close();
        }

        private void Odustani_Click(object sender, RoutedEventArgs e)
        {
            Logovanje logovanje = new Logovanje();
            logovanje.Show();
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
