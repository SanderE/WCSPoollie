using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms.Platform.Android;
using WCSPoollie.Shared;
using Xamarin.Forms;

namespace WCSPoollie.Droid
{
    [Activity()]
    //[Activity(MainLauncher = true)]
    public class TournamentListView : BaseWCSActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetPage(WCSPoollieApp.GetTournamentListPage());
        }
    }

    [Activity()]
    //[Activity(MainLauncher = true)]
    public class MainView : BaseWCSActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetPage(WCSPoollieApp.GetMainPage());
            this.Title = "OwnTitle";
            this.ActionBar.Title = "OwnActionBarTitle";
        }
    }

    //[Activity(MainLauncher = true, NoHistory = true, Theme = "@style/Theme.Splash", Icon = "@drawable/WCSLogo", Label = "WCS")]
    [Activity(MainLauncher = true, Icon = "@drawable/WCSLogo", Label = "WCS", NoHistory = true/*, Theme = "@style/Theme.Splash"*/)]
    //[Activity()]
    public class SplashView : BaseWCSActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetPage(WCSPoollieApp.GetSplashPage());
        }
    }

    public class BaseWCSActivity : AndroidActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Xamarin.Forms.Forms.Init(this, bundle);
            DependencyService.Get<INavigator>(DependencyFetchTarget.GlobalInstance).NavigationContext = this;
        }
    }
}