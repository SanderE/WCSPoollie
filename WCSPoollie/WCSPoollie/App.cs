using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WCSPoollie.Pages;
using WCSPoollie.ViewModels;
using Xamarin.Forms;

namespace WCSPoollie.Shared
{
    public class WCSPoollieApp
    {
        public static Page GetMainPage()
        {
            var np = new NavigationPage(new MainPage());
            np.Tint = Color.Blue;
            np.Icon = "WCSLogo";
            np.Title = "Titlol";            
            var items = np.ToolbarItems;
            
            return np;//new NavigationPage(new MainPage());
            //return new ContentPage
            //{
            //     BindingContext = navigationContext,
            //     Title = "NavPageTitle",
            //};
        }

        public static Page GetSplashPage()
        {
            var vm = new SplashViewModel();
            return new ContentPage
            {
                BackgroundImage = "splash",
                Title = "SPLASHSSH",
                BindingContext = vm
            };            
        }

        public static Page GetTournamentListPage()
        {
              
        }
    }
}
