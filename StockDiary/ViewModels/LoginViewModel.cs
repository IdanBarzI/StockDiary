using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Firebase.Auth;
using MVVMEssentials.Commands;
using MVVMEssentials.Services;
using MVVMEssentials.ViewModels;
using StockDiary.Commands;
using StockDiary.Stores;

namespace StockDiary.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private string _email;
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public ICommand SubmitCommand { get; }

        public ICommand NavigateRegisterCommand { get; }

        public LoginViewModel(AuthenticationStore authenticationStore, INavigationService registerNavigationService, INavigationService homenavigationService)
        {
            SubmitCommand = new LoginCommand(this, authenticationStore, homenavigationService);
            NavigateRegisterCommand = new NavigateCommand(registerNavigationService);
        }
    }
}
