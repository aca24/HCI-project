using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace MyApplication.Model
{
    [Serializable]
    public class Podaci
    {
        private Dictionary<String, GuestNalog> sviGuestNalozi;
        private Dictionary<String, PraviNalog> sviPraviNalozi;

       
        public Podaci()
        {
            sviGuestNalozi = new Dictionary<String, GuestNalog>();
            sviPraviNalozi = new Dictionary<String, PraviNalog>();
            
        }

        public Dictionary<String, GuestNalog> SviGuestNalozi
        {
            get { return sviGuestNalozi; }
            set
            {
                if (value != sviGuestNalozi)
                {
                    sviGuestNalozi = value;
                }
            }
        }


        public Dictionary<String, PraviNalog> SviPraviNalozi
        {
            get { return sviPraviNalozi; }
            set
            {
                if (value != sviPraviNalozi)
                {
                    sviPraviNalozi = value;
                }
            }
        }



    }
}

