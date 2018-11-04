using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Text.RegularExpressions;

namespace B4.PE2.HuygheK.classe
{
    public class Formulier 
    {
        public string naam = "";
        public string voornaam = "";
        public string email = ""; 
        public string telefoonnr = "";
        public string geboortedatum = "";
        public string onderwerp = "";
        public string bericht = "";
        public string gegevens = "";
        public void Bericht()
        {
            if (naam == "" || voornaam == "" || email == "" || telefoonnr == "" ||
                geboortedatum == "" || onderwerp == "" || bericht == "")
            {
                gegevens = "";
            }
            else {
                gegevens = "Onderwerp:" + onderwerp + "\n Naam:" + naam
                    + "\n Voornaam:" + voornaam + "\n Email:" + email
                    + "\n Telefoonnr:" + telefoonnr + "\n Geboortedatum:" + geboortedatum
                    + "\n Bericht:" + bericht;
            }
        }
        // bron https://stackoverflow.com/questions/1365407/c-sharp-code-to-validate-email-address
        public bool IsValidEmail(string email)
        {
            string expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    
                    return false;
                    
                }
            }
            else
            {
                return false;
            }
        }
    }
}
