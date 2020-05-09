using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using MyApplication.Model;

namespace MyApplication.Validation
{

   
    public class JmbgValidacija : ValidationRule
    {

        
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            
            string err1 = "Polje ne sme da stane prazno!".PadLeft(1);
            string err2 = "Nedozvoljen simbol".PadLeft(1);
            string err3 = "Duzina jmbg mora biti 13".PadLeft(1);
            try
            {
                var jmbg = value as string;

                if (String.IsNullOrWhiteSpace(jmbg))
                {
                    return new ValidationResult(false, err1);
                }
                else
                {
                    Regex r = new Regex(@"^[0-9]+$");
                    if (!r.IsMatch(jmbg))
                    {
                        // validation failed

                        return new ValidationResult(false, err2);
                    }
                }

                if (jmbg.Length.Equals(13))
                {
                    return new ValidationResult(true, null);
                }
                else
                {
                    return new ValidationResult(false, err3);
                }
            
            }
            catch
            {

                return new ValidationResult(false, "Greska!");
            }
        }

    } 
    
    public class BrojTelefonaValidacija : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            BindingExpression binExp = value as BindingExpression;
            PraviNalog praviNalog = binExp.DataItem as PraviNalog;

            string err1 = "Polje ne sme da stane prazno!".PadLeft(1);
            string err2 = "Nedozvoljen simbol".PadLeft(1);
            string err3 = "Duzina broja telefona mora biti 10".PadLeft(1);
            try
            {
                

                if (String.IsNullOrWhiteSpace(praviNalog.BrojTelefona))
                {
                    return new ValidationResult(false, err1);
                }
                else
                {
                    Regex r = new Regex(@"^[0-9]+$");
                    if (!r.IsMatch(praviNalog.BrojTelefona))
                    {
                        // validation failed

                        return new ValidationResult(false, err2);
                    }
                }

                if (praviNalog.BrojTelefona.Length.Equals(10))
                {
                    return new ValidationResult(true, null);
                }
                else
                {
                    return new ValidationResult(false, err3);
                }

            }
            catch
            {

                return new ValidationResult(false, "Greska!");
            }
        }
    }


    public class EmailValidacija : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            BindingExpression binExp = value as BindingExpression;
            PraviNalog praviNalog = binExp.DataItem as PraviNalog;

            
            string err = "Polje ne sme da stane prazno!".PadLeft(1);
            string err2 = "Nedozvoljen simbol!".PadLeft(1);
            
            try
            {

                if (String.IsNullOrWhiteSpace(praviNalog.Email))
                {
                    return new ValidationResult(false, err);
                }
                Regex r = new Regex(@"^[a-zA-Z0-9_@.]+$");
                if (!r.IsMatch(praviNalog.Email))
                {
                    // validation failed

                    return new ValidationResult(false, err2);
                }
                else
                {
                    
                   return new ValidationResult(true, null);
                }
            }
            catch
            {

                return new ValidationResult(false, "Greska!");
            }
        }
    }
}
