using System;
using System.ComponentModel;


namespace MyApplication.Model
{
    public class GuestNalog
    {
        private  String _jmbg;
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

        public bool IsEqual(GuestNalog guestNalog)
        {
            if (guestNalog != null)
            {
                if (Jmbg.Equals(guestNalog.Jmbg))
                {
                    return true;
                }
            }

            return false;
        }

        public void PreuzmiOd(GuestNalog izvorniGuest)
        {
            Jmbg = izvorniGuest.Jmbg;
            Ime = izvorniGuest.Ime;
            Prezime = izvorniGuest.Prezime;
        }
    }
}
