﻿using B4.PE2.HuygheK.classe;
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
       // DateTime t = DateTime.Now;
        TijdMeter tijdmeter = new TijdMeter();
        

        public Timer()
        {
            InitializeComponent();
            SizeChanged += (object sender, EventArgs args) =>
                 {
                     if (this.Width > 0) Tijdmelding.FontSize = this.Width / 15;
                };
        }


        private void BtnStartstop_Clicked (object sender, EventArgs e)
        {
            Device.StartTimer(TimeSpan.FromMilliseconds(10), () =>
            {
                TimeSpan span = (tijdmeter.t - DateTime.Now);
                if (tijdmeter.wissel == true)
                {
                    Tijdmelding.Text = span.ToString("c");
                }
                return true;
            });
            if (tijdmeter.wissel == true)
            {
                tijdmeter.Start();
                (sender as Button).Text = "Start";
                
            }
            else
            {
                (sender as Button).Text = "Stop";
                tijdmeter.Stop();
                Tijdmelding.Text = tijdmeter.tijd;
            }
        }
	    
    }
}


 
