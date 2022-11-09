using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMEssentials.ViewModels;
using StockDiary.Stores;

namespace StockDiary.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public AuthenticationStore _authenticationStore { get; set; }


        public string Username => _authenticationStore.CurrentUser?.DisplayName ?? "Unknown";

        public HomeViewModel(AuthenticationStore authenticationStore)
        {
            _authenticationStore = authenticationStore;
        }
    }
}
