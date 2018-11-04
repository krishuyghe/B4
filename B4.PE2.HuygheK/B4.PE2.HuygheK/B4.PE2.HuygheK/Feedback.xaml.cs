using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using B4.PE2.HuygheK.classe;


namespace B4.PE2.HuygheK
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Feedback : ContentPage
	{
        Formulier formulier = new Formulier();
        public Feedback ()
		{
			InitializeComponent ();
		}
        private async void TbiSave_Clicked(object sender, EventArgs e)
        {
            if (txtName.Text != null) { formulier.naam = txtName.Text; }
            if (txtVoorNaam.Text != null) { formulier.voornaam = txtVoorNaam.Text; }
            if (txtEmail.Text != null) { formulier.email = txtEmail.Text; }
            if (txtTelefoonnummer.Text != null) { formulier.telefoonnr = txtTelefoonnummer.Text; }
            if (txtGeboorte.Date.Year != DateTime.Now.Year ) { formulier.geboortedatum = txtGeboorte.Date.ToString().Substring(0, 10); }
            if (txtOnderwerp.SelectedItem != null) { formulier.onderwerp = txtOnderwerp.Items[txtOnderwerp.SelectedIndex]; }
            if (txtBericht.Text != null) { formulier.bericht = txtBericht.Text; }

            if (formulier.IsValidEmail(formulier.email) == false)
            {
                await DisplayAlert("Email fout", "Email adres is niet correct", "ok");
                formulier.email = "";
            }

            

            formulier.Bericht();
            if (formulier.gegevens == "")
            {
                await DisplayAlert("Nietverzonden", "Uw formulier niet verzonden gelieve alle velden in te vullen", "ok");
            }
            else
            {
                await DisplayAlert("Verzonden", "Uw formulier is verzonden \n" + formulier.gegevens, "ok");
            }
                
    
               // string strMailTo = @"mailto:kr.huyghe@gmail.com?Subject=" + onderwerp + "&Body=" + body;
             //   Device.OpenUri(new Uri(strMailTo));
 
            }


        }

    }
