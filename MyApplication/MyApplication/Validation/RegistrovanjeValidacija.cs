using MyApplication.Model;
using MyApplication.View;
using System;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;

namespace MyApplication.Validation
{
    public class RegistrovanjeValidacija : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            BindingExpression binExp = value as BindingExpression;
            Registrovanje reg = binExp.DataItem as Registrovanje;
            UserInfo userInfo = new UserInfo();
            if (String.IsNullOrEmpty(reg.Username))
            {
                return new ValidationResult(false, "Morate uneti korisničko ime.");
            }
            else if (userInfo.CheckExistence(reg.Username))
            {
                return new ValidationResult(false, "Korisnik sa tim korisničkim imenom već postoji.");
            }

            return new ValidationResult(true, null);
        }
    }

    public class RegLozinkaValidacija : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            BindingExpression binExp = value as BindingExpression;
            Registrovanje reg = binExp.DataItem as Registrovanje;
            if (String.IsNullOrEmpty(reg.Password))
            {
                return new ValidationResult(false, "Morate uneti lozinku.");
            }

            return new ValidationResult(true, null);
        }
    }

    public class PodudaranjeLozinkeValidacija : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            BindingExpression binExp = value as BindingExpression;
            Registrovanje reg = binExp.DataItem as Registrovanje;
            if (String.IsNullOrEmpty(reg.PassMatch))
            {
                return new ValidationResult(false, "Morate ponoviti lozinku radi provere.");
            }
            else if (!reg.PassMatch.Equals(reg.Password))
            {
                return new ValidationResult(false, "Lozinke se ne podudaraju. Pokušajte ponovo.");
            }

            return new ValidationResult(true, null);
        }
    }
}
