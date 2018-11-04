using B4.PE2.HuygheK.classe;
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
        TijdMeter tijdmeter = new TijdMeter();
               
        public LapTimer()
        {
            InitializeComponent();
            Lap.IsEnabled = false;
            SizeChanged += (object sender, EventArgs args) =>
            {
                if (this.Width > 0)
                {
                    Tijdmelding.FontSize = this.Width / 15;
                    LapTekst.FontSize = this.Width / 20;
                    Start.FontSize = this.Width / 13;
                    Lap.FontSize = this.Width / 13;
                }

            };
        }
        private void BtnStart_Clicked(object sender, EventArgs e)
	    {
            Device.StartTimer(TimeSpan.FromMilliseconds(10), () =>
            {
                
                TimeSpan span = (tijdmeter.t - DateTime.Now);
                if (tijdmeter.wissel == true)
                {
                    tijdmeter.tijd = span.ToString("c").Substring(1);
                    Tijdmelding.Text = tijdmeter.tijd;    
                }
                return true;
            });
            if (tijdmeter.wissel == true)
            {
                Lap.IsEnabled = false;
                (sender as Button).Text = "Start";
                tijdmeter.Start();
                tijdmeter.Lap();
                LapTekst.Text = tijdmeter.lapText;
                
            }
            else
            {
                tijdmeter.Stop();
                Lap.IsEnabled = true;
                LapTekst.Text = tijdmeter.lapText;
                (sender as Button).Text = "Stop";
                Tijdmelding.Text = tijdmeter.tijd;
            }

        }
	    private void BtnLap_Clicked(object sender, EventArgs e)
	    {
            tijdmeter.Lap();
            LapTekst.Text = tijdmeter.lapText;
            

        }
        


    }
}