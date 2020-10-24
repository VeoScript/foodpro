using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Graphics;
using System;

namespace FoodPro
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true, ConfigurationChanges = Android.Content.PM.ConfigChanges.ScreenSize | Android.Content.PM.ConfigChanges.Orientation, ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.loginform);

            //para ni sa pag declare ug Custom Fonts... (LOGIN FORM)
            var lblAppTitle = FindViewById<TextView>(Resource.Id.apptitle);
            var lblSubAppTitle = FindViewById<TextView>(Resource.Id.subapptitle);
            var lblLogintxt = FindViewById<TextView>(Resource.Id.logintxt);
            var lblLabelUsername = FindViewById<TextView>(Resource.Id.labelUsername);
            var txtUsername = FindViewById<TextView>(Resource.Id.txtUsername);
            var lblLabelPassword = FindViewById<TextView>(Resource.Id.labelPassword);
            var txtPassword = FindViewById<TextView>(Resource.Id.txtPassword);
            var btnLogin = FindViewById<TextView>(Resource.Id.btnLogin);
            var btnDontHaveAccount = FindViewById<TextView>(Resource.Id.btnCreateAccount);
            var lblcopyright = FindViewById<TextView>(Resource.Id.lblcopyright);

            //mao na ni ang mga fonts na gideclared (LOGIN FORM)
            Typeface font1 = Typeface.CreateFromAsset(Assets, "simplo_heavy.otf");
            lblAppTitle.SetTypeface(font1, TypefaceStyle.Normal);
            Typeface font2 = Typeface.CreateFromAsset(Assets, "simplo_thin.otf");
            lblSubAppTitle.SetTypeface(font2, TypefaceStyle.Normal);
            Typeface font3 = Typeface.CreateFromAsset(Assets, "simplo_bold.otf");
            lblLogintxt.SetTypeface(font3, TypefaceStyle.Normal);
            Typeface font4 = Typeface.CreateFromAsset(Assets, "simplo_thin.otf");
            lblLabelUsername.SetTypeface(font4, TypefaceStyle.Normal);
            Typeface font5 = Typeface.CreateFromAsset(Assets, "simplo_regular.otf");
            txtUsername.SetTypeface(font5, TypefaceStyle.Normal);
            Typeface font6 = Typeface.CreateFromAsset(Assets, "simplo_thin.otf");
            lblLabelPassword.SetTypeface(font6, TypefaceStyle.Normal);
            Typeface font7 = Typeface.CreateFromAsset(Assets, "simplo_regular.otf");
            txtPassword.SetTypeface(font7, TypefaceStyle.Normal);
            Typeface font8 = Typeface.CreateFromAsset(Assets, "simplo_thin.otf");
            btnLogin.SetTypeface(font8, TypefaceStyle.Normal);
            Typeface font9 = Typeface.CreateFromAsset(Assets, "simplo_thin.otf");
            btnDontHaveAccount.SetTypeface(font9, TypefaceStyle.Normal);
            Typeface font10 = Typeface.CreateFromAsset(Assets, "simplo_thin.otf");
            lblcopyright.SetTypeface(font10, TypefaceStyle.Normal);

            //navigation code padong didtos About page...
            Button btnAbout = FindViewById<Button>(Resource.Id.btnAbout);
            btnAbout.Click += delegate { StartActivity(typeof(AboutActivity)); };
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}