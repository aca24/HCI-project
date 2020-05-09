using MyApplication.Model;
using MyApplication.View;
using System;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;

namespace MyApplication.Validation
{
    public class LogovanjeValidacija : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            BindingExpression binExp = value as BindingExpression;
            Logovanje log = binExp.DataItem as Logovanje;
            UserInfo userInfo = new UserInfo();

            if (String.IsNullOrEmpty(log.Username))
            {
                return new ValidationResult(false, "Morate uneti korisničko ime.");
            }
            else if (!userInfo.CheckExistence(log.Username))
            {
                return new ValidationResult(false, "Nema korisnika sa ovim korisničkim imenom.");
            }
            else
            {
                return new ValidationResult(true, null);
            }
        }
    }

    public class LozinkaValidacija : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            BindingExpression binExp = value as BindingExpression;
            Logovanje log = binExp.DataItem as Logovanje;
            UserInfo userInfo = new UserInfo();
            if (String.IsNullOrEmpty(log.Password))
            {
                return new ValidationResult(false, "Morate uneti lozinku.");
            }

            return new ValidationResult(true, null);
        }
    }
}
