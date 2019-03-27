using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace Lab3
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var edtName = FindViewById<EditText>(Resource.Id.edtName);
            var edtEmail = FindViewById<EditText>(Resource.Id.edtMail);
            var btnSend = FindViewById<Button>(Resource.Id.btnSend);
            btnSend.Click += (s, e) =>
            {
                Intent nextActivity = new Intent(this, typeof(RecvActivity));
                nextActivity.PutExtra("name", edtName.Text);
                nextActivity.PutExtra("email", edtEmail.Text);
                StartActivity(nextActivity);
            };
        }
    }
}