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
using WCSPoollie.Shared;
using Xamarin.Forms;
using WCSPoollie.Droid;

[assembly: Dependency(typeof(Navigator))]
namespace WCSPoollie.Droid
{
    public class Navigator : INavigator
    {
        //private static readonly Lazy<Navigator> lazy = new Lazy<Navigator>(() => new Navigator());

        //public static Navigator Instance { get { return lazy.Value; } }

        public Navigator() { }

        public object NavigationContext { get; set; }

        private void Navigate(Type type)
        {
            if (NavigationContext == null) return;
            //if (AndroidHelpers.CurrentActivity != null && AndroidHelpers.CurrentActivity.GetType() == type) return;
            ((Context)NavigationContext).StartActivity(type);
        }

        private void Navigate(Type type, List<ActivityFlags> flags)
        {
            if (NavigationContext == null) return;
            //if (AndroidHelpers.CurrentActivity != null && AndroidHelpers.CurrentActivity.GetType() == type) return;
            Intent i = new Intent((Context)NavigationContext, type);
            if (flags != null && flags.Count > 0)
            {
                foreach (ActivityFlags flag in flags)
                    i.AddFlags(flag);
            }

            ((Context)NavigationContext).StartActivity(i);
        }

        public void NavigateToMainView()
        {
            Navigate(typeof(MainView));
        }
    }
}