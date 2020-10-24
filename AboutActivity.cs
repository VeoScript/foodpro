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
using Android.Graphics;
using Android.Views.TextClassifiers;

namespace FoodPro
{
    [Activity(Label = "AboutActivity")]
    public class AboutActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.aboutform);

            //para ni sa pag declare ug Custom Fonts... (ABOUT FORM)
            var lblAboutLabel = FindViewById<TextView>(Resource.Id.lblAboutLabel);
            var lblAboutParagraph = FindViewById<TextView>(Resource.Id.lblAboutParagraph);
            var lblAboutDeveloperLabel = FindViewById<TextView>(Resource.Id.lblAboutDeveloperLabel);
            var lblAboutDeveloperParagraph = FindViewById<TextView>(Resource.Id.lblAboutDeveloperParagraph);
            var lblLink = FindViewById<TextView>(Resource.Id.lblLink);
            var lblcopyright = FindViewById<TextView>(Resource.Id.lblcopyright);

            //mao na ni ang mga fonts na gideclared (ABOUT FORM)
            Typeface font1 = Typeface.CreateFromAsset(Assets, "simplo_heavy.otf");
            lblAboutLabel.SetTypeface(font1, TypefaceStyle.Normal);
            Typeface font2 = Typeface.CreateFromAsset(Assets, "simplo_light.otf");
            lblAboutParagraph.SetTypeface(font2, TypefaceStyle.Normal);
            Typeface font3 = Typeface.CreateFromAsset(Assets, "simplo_heavy.otf");
            lblAboutDeveloperLabel.SetTypeface(font3, TypefaceStyle.Normal);
            Typeface font4 = Typeface.CreateFromAsset(Assets, "simplo_light.otf");
            lblAboutDeveloperParagraph.SetTypeface(font4, TypefaceStyle.Normal);
            Typeface font5 = Typeface.CreateFromAsset(Assets, "simplo_light.otf");
            lblLink.SetTypeface(font5, TypefaceStyle.Normal);
            Typeface font10 = Typeface.CreateFromAsset(Assets, "simplo_thin.otf");
            lblcopyright.SetTypeface(font10, TypefaceStyle.Normal);

            //text paragraph para sa pag display sa about
            TextView display1 = FindViewById<TextView>(Resource.Id.lblAboutParagraph);
            display1.Text = "This application is for SPMI Employees only. \n Use this program to buy foods in canteen \n here in SPMI Plant online. \n\n However this application \n can purchase by any company. \n For more information about this app view at \n The Developer".ToString();

            //text paragraph para sa pag display sa about
            TextView display2 = FindViewById<TextView>(Resource.Id.lblAboutDeveloperParagraph);
            display2.Text = "This program application was \n designed and developed by \n Jerome Villaruel VEOSCRIPT \n using Visual Studio Xamarin in C#. \n Visit my official website the link below \n for project contribution on github or to \n purchase my program applications.".ToString();
        }
    }
}