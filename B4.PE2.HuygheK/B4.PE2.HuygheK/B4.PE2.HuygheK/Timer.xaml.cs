using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace B4.PE2.HuygheK
{
    



    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Timer : ContentPage
    {
        DateTime t = DateTime.Now;
        public string tijd = "";
        public bool wissel = false;
        public Timer()
        {
            InitializeComponent();
            SizeChanged += (object sender, EventArgs args) =>
                 {
                     if (this.Width > 0) Tijdmelding.FontSize = this.Width / 25;
                };
        }


        private void BtnStartstop_Clicked (object sender, EventArgs e)
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
                wissel = false;
            }
            else
            {
                string a = tijd;
                (sender as Button).Text = "Stop";
                wissel = true;
                Tijdmelding.Text = tijd;
            }
        }
	    
    }
}


 
