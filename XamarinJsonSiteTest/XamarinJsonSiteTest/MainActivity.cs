using Android.App;
using Android.Widget;
using Android.OS;

namespace XamarinJsonSiteTest
{
    [Activity(Label = "XamarinJsonSiteTest", MainLauncher = true)]
    public class MainActivity : Activity
    {
        public TextView login;
        public TextView loginText;
        public TextView passwordText;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            login = FindViewById<TextView>(Resource.Id.login);
            loginText = FindViewById<TextView>(Resource.Id.email);
            passwordText = FindViewById<TextView>(Resource.Id.password);


        }
    }
}

