using System;
using Xamarin.Forms;

namespace GreetingsSAP
{
	public class GreetingsSAPPage : ContentPage
	{
		public GreetingsSAPPage ()
		{
            var MyLabel = new Label();
            MyLabel.Text = "Greetings, Xamarin.Forms!";
            this.Content = MyLabel;

            MyLabel.HorizontalOptions = LayoutOptions.Center;
            MyLabel.VerticalOptions = LayoutOptions.Center;
            MyLabel.HorizontalTextAlignment = TextAlignment.Center;
            MyLabel.VerticalTextAlignment = TextAlignment.Center;

            Padding = Device.OnPlatform<Thickness>(
             new Thickness(0, 20, 0, 0),
             new Thickness(0),
             new Thickness(0));

        }
    }
}
