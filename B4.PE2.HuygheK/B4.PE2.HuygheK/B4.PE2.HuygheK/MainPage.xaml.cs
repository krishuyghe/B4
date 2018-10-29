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
            SizeChanged += (object sender, EventArgs args) =>
            {
                if (this.Width > 0)
                {
                    BtnLapTimer.FontSize = this.Width / 13;
                    BtnTimer.FontSize = this.Width / 13;
                    BtnFeedback.FontSize = this.Width / 13;

                }
            };
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
