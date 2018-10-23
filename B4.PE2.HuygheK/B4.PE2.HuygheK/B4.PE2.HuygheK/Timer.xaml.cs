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
        public bool wissel = true;
        public Timer()
        {
            InitializeComponent();
           
            // Button startButton = new Button();

            //    startButton.Text = "Start";
            //  Label clockLabel = new Label();
            //     StackLayout stack = new StackLayout
            //   {
            //      Orientation = StackOrientation.Vertical,
            //      Children =
            //     {
            //          startButton,
            //           clockLabel

            //         }
            //    };



            //  {HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center };

            //        clockLabel.Text = DateTime.Now.ToString("h:mm:ss tt");
            //        Content = stack ;

            //      SizeChanged += (object sender, EventArgs args) =>
            //      {
            //         if (this.Width > 0) clockLabel.FontSize = this.Width / 25;
            //    };
            //   Device.StartTimer(TimeSpan.FromMilliseconds(10), () =>
            //   {

            //      TimeSpan span = (t - DateTime.Now);
            //      tijd = "{0:%d} day, {0:%h} hour, {0:%m} min, {0:%s} sec, . {0:%fffffff} ";
            //     clockLabel.Text = string.Format(tijd , span);

            // clockLabel.Text = string.Format("{ 0:MM / dd / yy H: mm: ss zzz}", span);
            //       DateTime date1 = DateTime.Now;
            //      int result = DateTime.Compare(date1, t);
            // clockLabel.Text = result.ToString();

            //       return true;
            //  });
        }
   

        private async void BtnStartstop_Clicked (object sender, EventArgs e)
        {
            if (wissel == true)
            {
                (sender as Button).Text = "Stop";
                wissel = false;
                Tijdmelding.Text = "geprobeerd";
               
            }
            else
            {
                (sender as Button).Text = "Start";
                wissel = true;
            }
            
            // Button StopButton = new Button();
            //  StopButton.Text = "Stop";
            //   Label clockLabel = new Label();
            //   StackLayout stack = new StackLayout
            //  {
            //      Orientation = StackOrientation.Vertical,
            //      Children =
            //   {
            //            StopButton,
            //            clockLabel

            //       }
            //   };
            //  Content = stack;
            //   Device.StartTimer(TimeSpan.FromMilliseconds(10), () =>
            //   {


            //       TimeSpan span = (t - DateTime.Now);
            //      tijd = "{0:%d} day, {0:%h} hour, {0:%m} min, {0:%s} sec, . {0:%fffffff} ";
            //       clockLabel.Text = string.Format(tijd, span);

            // clockLabel.Text = string.Format("{ 0:MM / dd / yy H: mm: ss zzz}", span);
            //      DateTime date1 = DateTime.Now;
            //      int result = DateTime.Compare(date1, t);
            // clockLabel.Text = result.ToString();

            //     return true;
            //   });

        }
	    
    }
}


 
