using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;

namespace MyApplication.Model
{
    public class PraviNalog 
    {
        private String _brojTelefona;
        private String _email;
        private DateTime _datumRodjenja;
        private String _jmbg;
        private String _ime;
        private String _prezime;


        protected virtual void OnPropertyChanged(String name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        public String Jmbg
        {
            get { return _jmbg; }
            set
            {
                if (value != _jmbg)
                {
                    _jmbg = value;
                    OnPropertyChanged("Jmbg");
                }
            }
        }

        public String Ime
        {
            get { return _ime; }
            set
            {
                if (value != _ime)
                {
                    _ime = value;
                    OnPropertyChanged("Ime");
                }
            }
        }

        public String Prezime
        {
            get { return _prezime; }
            set
            {
                if (value != _prezime)
                {
                    _prezime = value;
                    OnPropertyChanged("Prezime");
                }
            }
        }

        public String BrojTelefona
        {
            get { return _brojTelefona; }
            set
            {
                if (value != _brojTelefona)
                {
                    _brojTelefona = value;
                    OnPropertyChanged("BrojTelefona");
                }
            }
        }

        public String Email
        {
            get { return _email; }
            set
            {
                if (value != _email)
                {
                    _email = value;
                    OnPropertyChanged("Email");
                }
            }
        }

        public DateTime DatumRodjenja
        {
            get { return _datumRodjenja; }
            set
            {
                if (value != _datumRodjenja)
                {
                    _datumRodjenja = value;
                    OnPropertyChanged("DatumRodjenja");
                }
            }
        }

    }
}
