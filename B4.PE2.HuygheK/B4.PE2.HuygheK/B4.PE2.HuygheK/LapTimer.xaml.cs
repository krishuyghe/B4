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
	public partial class LapTimer : ContentPage
	{
        DateTime t = DateTime.Now;
        public string tijd = "";
        public bool wissel = false;
        public int lapTeller = 0;
        public string lapText = "";
        public LapTimer()
        {
            InitializeComponent();
            
        }
        private async void BtnStart_Clicked(object sender, EventArgs e)
	    {
            Device.StartTimer(TimeSpan.FromMilliseconds(10), () =>
            {
                
                TimeSpan span = (t - DateTime.Now);
                if (wissel == true)
                {
                    tijd = span.ToString("c");
                    Tijdmelding.Text = tijd;
                }
                return true;
            });
            if (wissel == true)
            {
                (sender as Button).Text = "Start";
                t = DateTime.Now;
                lapTeller++;
                lapText = lapText + "lap " + lapTeller.ToString() + " Duur:" + tijd + "\n";
                LapTekst.Text = lapText;
                wissel = false;
            }
            else
            {
                lapText = "";
                lapTeller = 0;
                LapTekst.Text = lapText;
                string a = tijd;
                (sender as Button).Text = "Stop";
                wissel = true;
                Tijdmelding.Text = tijd;
            }

        }
	    private async void BtnLap_Clicked(object sender, EventArgs e)
	    {
            lapTeller++;
            lapText = lapText + "lap "+ lapTeller.ToString() + " Duur:" + tijd + "\n";
            LapTekst.Text = lapText;
            t = DateTime.Now;

        }
        private async void BtnStop_Clicked(object sender, EventArgs e)
	    {


	    }


    }
}