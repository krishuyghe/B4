using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace B4.PE1.HuygheK
{
	

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Wiki : ContentPage
    {
        public Wiki()
        {
            InitializeComponent();
        }

        private async void btnPopupHello_Clicked(object sender, System.EventArgs e)
        {
            await DisplayAlert("Alert", "Hello there!", "Hi!");
        }

        private async void btnGoBack_Clicked(object sender, System.EventArgs e)
        {
            if (await DisplayAlert("Goin' back", "Wanna go back?", "Yep", "No, wait!"))
                await Navigation.PopAsync(true);
        }
    }
}