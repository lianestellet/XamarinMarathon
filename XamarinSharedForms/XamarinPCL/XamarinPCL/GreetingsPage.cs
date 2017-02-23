using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace XamarinPCL
{
    public class GreetingsPage : ContentPage
    {
        public GreetingsPage()
        {
            var MyLabel = new Label();
            MyLabel.Text = "Greetings, Xamarin.Forms!";
            this.Content = MyLabel;
            Padding = new Thickness(0, 20, 0, 0);

            //Content = new StackLayout
            //{
            //    Children = {
            //        new Label { Text = "Hello Page" }
            //    }
            //};
        }
    }
}
