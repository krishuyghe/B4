using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace B4.PE1.HuygheK
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private async void BtnWiki_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Wiki(), false);

        }


        private async void BtnPic_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Picture(), false);

        }
    }

}