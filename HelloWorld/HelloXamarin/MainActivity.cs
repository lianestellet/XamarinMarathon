using Android.App;
using Android.Widget;
using Android.OS;

namespace HelloXamarin
{
    [Activity(Label = "HelloXamarin", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            //Get our button from the layout resource.
            //And Attach event to it
            Button button = FindViewById<Button>(Resource.Id.button1);

            button.Click += delegate
            {
                //button.Text = string.Format("STOP THIS PERV! YOU TOUCHED {0} TIMES ALREADY", count++);
                string text = string.Empty;
                switch (count)
                {
                    case 1:
                        text = "You touch my tralala ~";
                        break;
                    case 2:
                        text = "My ding ding dong";
                        break;
                    case 3:
                        text = "Ok.. you can stop now..";
                        break;
                    default:
                        text = string.Format("STOP THIS PERV! YOU TOUCHED {0} TIMES ALREADY", count);
                        break;
                }
                button.Text = text;
                count++;
            };

        }
    }
}

