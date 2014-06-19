using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCSPoollie.Shared;
using Xamarin.Forms;

namespace WCSPoollie.ViewModels
{
    public class SplashViewModel
    {
        public SplashViewModel()
        {
            DependencyService.Get<INavigator>(DependencyFetchTarget.GlobalInstance).NavigateToMainView();
        }
    }
}
