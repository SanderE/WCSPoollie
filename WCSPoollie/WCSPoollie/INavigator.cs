using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCSPoollie.Shared
{
    public interface INavigator
    {
        object NavigationContext { get; set; }
        void NavigateToMainView();
    }
}
