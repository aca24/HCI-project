using MyApplication.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace MyApplication.Validation
{
    public class ImeValidacija : ValidationRule
    {
        private string FirstCharToUpper(string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentException("ARGH!");
            return input.First().ToString().ToUpper() + input.Substring(1);
        }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
           
            BindingExpression binExp = value as BindingExpression;
            GuestNalog guestNalog = binExp.DataItem as GuestNalog; 

            string err = "Polje ne sme da stane prazno!".PadLeft(1);
            string err2 = "Nedozvoljen simbol!".PadLeft(1);
            string err3 = "Prvo slovo mora biti veliko!".PadLeft(1);
            try
            {
               
                if (String.IsNullOrWhiteSpace(guestNalog.Ime))
                {
                    return new ValidationResult(false, err);
                }
                Regex r = new Regex(@"^[šŠđĐčČćĆžŽa-zA-Z]+$");
                if (!r.IsMatch(guestNalog.Ime))
                {
                    // validation failed

                    return new ValidationResult(false, err2);
                }else
                {
                    if(guestNalog.Ime.Equals(FirstCharToUpper(guestNalog.Ime)))
                        return new ValidationResult(true, null);
                    else
                        return new ValidationResult(false, err3);
                }
            }
            catch
            {

                return new ValidationResult(false, "Greska!");
            }
        }
    }

    public class ImeValidacija1 : ValidationRule
    {
        private string FirstCharToUpper(string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentException("ARGH!");
            return input.First().ToString().ToUpper() + input.Substring(1);
        }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {

            BindingExpression binExp = value as BindingExpression;
            PraviNalog praviNalog = binExp.DataItem as PraviNalog;

            string err = "Polje ne sme da stane prazno!".PadLeft(1);
            string err2 = "Nedozvoljen simbol!".PadLeft(1);
            string err3 = "Prvo slovo mora biti veliko!".PadLeft(1);
            try
            {

                if (String.IsNullOrWhiteSpace(praviNalog.Ime))
                {
                    return new ValidationResult(false, err);
                }
                Regex r = new Regex(@"^[šŠđĐčČćĆžŽa-zA-Z]+$");
                if (!r.IsMatch(praviNalog.Ime))
                {
                    // validation failed

                    return new ValidationResult(false, err2);
                }
                else
                {
                    if (praviNalog.Ime.Equals(FirstCharToUpper(praviNalog.Ime)))
                        return new ValidationResult(true, null);
                    else
                        return new ValidationResult(false, err3);
                }
            }
            catch
            {

                return new ValidationResult(false, "Greska!");
            }
        }
    }
    public class PrezimeValidacija : ValidationRule
    {
        private string FirstCharToUpper(string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentException("ARGH!");
            return input.First().ToString().ToUpper() + input.Substring(1);
        }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {

            BindingExpression binExp = value as BindingExpression;
            GuestNalog guestNalog = binExp.DataItem as GuestNalog;

            string err = "Polje ne sme da stane prazno!".PadLeft(1);
            string err2 = "Nedozvoljen simbol!".PadLeft(1);
            string err3 = "Prvo slovo mora biti veliko!".PadLeft(1);
            try
            {

                if (String.IsNullOrWhiteSpace(guestNalog.Prezime))
                {
                    return new ValidationResult(false, err);
                }
                Regex r = new Regex(@"^[šŠđĐčČćĆžŽa-zA-Z]+$");
                if (!r.IsMatch(guestNalog.Prezime))
                {
                    // validation failed

                    return new ValidationResult(false, err2);
                }
                else
                {
                    if (guestNalog.Prezime.Equals(FirstCharToUpper(guestNalog.Prezime)))
                        return new ValidationResult(true, null);
                    else
                        return new ValidationResult(false, err3);
                }
            }
            catch
            {

                return new ValidationResult(false, "Greska!");
            }
        }
    }

    public class PrezimeValidacija1 : ValidationRule
    {
        private string FirstCharToUpper(string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentException("ARGH!");
            return input.First().ToString().ToUpper() + input.Substring(1);
        }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {

            BindingExpression binExp = value as BindingExpression;
            PraviNalog praviNalog = binExp.DataItem as PraviNalog;

            string err = "Polje ne sme da stane prazno!".PadLeft(1);
            string err2 = "Nedozvoljen simbol!".PadLeft(1);
            string err3 = "Prvo slovo mora biti veliko!".PadLeft(1);
            try
            {

                if (String.IsNullOrWhiteSpace(praviNalog.Prezime))
                {
                    return new ValidationResult(false, err);
                }
                Regex r = new Regex(@"^[šŠđĐčČćĆžŽa-zA-Z]+$");
                if (!r.IsMatch(praviNalog.Prezime))
                {
                    // validation failed

                    return new ValidationResult(false, err2);
                }
                else
                {
                    if (praviNalog.Prezime.Equals(FirstCharToUpper(praviNalog.Prezime)))
                        return new ValidationResult(true, null);
                    else
                        return new ValidationResult(false, err3);
                }
            }
            catch
            {

                return new ValidationResult(false, "Greska!");
            }
        }
    }
}
