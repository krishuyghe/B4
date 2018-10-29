using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace B4.PE2.HuygheK
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Feedback : ContentPage
	{
		public Feedback ()
		{
			InitializeComponent ();
		}
        private async void TbiSave_Clicked(object sender, EventArgs e)
        {
            if (txtBericht.Text != null && txtEmail.Text != null && txtName.Text != null && txtOnderwerp.ToString() != null 
                && txtTelefoonnummer.ToString() != null && txtVoorNaam.Text != null )
            {
                string onderwerp = txtOnderwerp.Items[txtOnderwerp.SelectedIndex];
                string body = "Onderwerp: " + txtOnderwerp.Items[txtOnderwerp.SelectedIndex];
                body = "Naam: " + txtName.Text + "\n";
                body += "Voornaam: " + txtVoorNaam.Text + "\n";
                body += "Email: " + txtEmail.Text + "\n";
                body += "Telefoonnr: " + txtTelefoonnummer.Text + "\n";
                body += "geboortedatum: " + txtGeboorte.Date.ToString().Substring(0,10) + "\n";
                body += "Bericht: " + txtBericht.Text;
                string strMailTo = @"mailto:kr.huyghe@gmail.com?Subject=" + onderwerp + "&Body=" + body;
                Device.OpenUri(new Uri(strMailTo));
                await DisplayAlert("Verzonden", "Uw formulier is verzonden \n" + body , "ok");

                // Alternatively use EmailBuilder fluent interface to construct more complex e-mail with multiple recipients, bcc, attachments etc. 
                
            }
            else
            {
                await DisplayAlert("Nietverzonden", "Uw formulier niet verzonden gelieve alle velden in te vullen", "ok");
            }

        }

    }
}