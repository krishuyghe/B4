using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace B4.PE2.HuygheK
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void BtnTimer_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Timer(), false);
           
        }
        private async void BtnLapTimer_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LapTimer(), false);

        }
        private async void BtnFeedback_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Feedback(), false);

        }
    }
}
