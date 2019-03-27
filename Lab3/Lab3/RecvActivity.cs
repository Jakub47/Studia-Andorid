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

namespace Lab3
{
    [Activity(Label = "RecvActivity")]
    public class RecvActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.RecActivity);
            string name = Intent.GetStringExtra("name" ?? "Not recv");
            string email = Intent.GetStringExtra("email" ?? "Not recv");
            var textName = FindViewById<TextView>(Resource.Id.textView1);
            var txtEmail = FindViewById<TextView>(Resource.Id.txtEmail);
            var btnGoBack = FindViewById<TextView>(Resource.Id.button1);

            txtEmail.Text = email;
            textName.Text = name;
            btnGoBack.Click += delegate { this.Finish(); };
        }
    }
}