using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Org.Apache.Http.Client;

namespace AlertasSolidarias
{
    [Activity(Label = "LoginActivity", MainLauncher = true)]

    public class LoginActivity : Activity
    {
        private EditText etUser;
        private EditText etPass;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.Login);

            etUser = this.FindViewById<EditText>(Resource.Id.etUsername);
            etPass = this.FindViewById<EditText>(Resource.Id.etPassword);


            // Create your application here
        }
    }
}