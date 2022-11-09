using System;
using Firebase.Auth;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMEssentials.Commands;
using StockDiary.ViewModels;
using System.Windows;
using MVVMEssentials.Services;

namespace StockDiary.Commands
{
    public class RegisterCommand : AsyncCommandBase
    {
        private readonly RegisterViewModel _registerViewModel;
        private readonly FirebaseAuthProvider _fireBaseAuthProvider;
        private readonly INavigationService _loginNavigationService;


        public RegisterCommand(RegisterViewModel registerViewModel, FirebaseAuthProvider fireBaseAuthProvider, INavigationService loginNavigationService)
        {
            _registerViewModel = registerViewModel;
            _fireBaseAuthProvider = fireBaseAuthProvider;
            _loginNavigationService = loginNavigationService;
        }

        protected override async Task ExecuteAsync(object parameter)
        {
            string password = _registerViewModel.Password;
            string confirmPassword = _registerViewModel.ConfirmPassword;

            if (password != confirmPassword)
            {
                MessageBox.Show("Password and confirm password must match.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try
            {   
                await _fireBaseAuthProvider.CreateUserWithEmailAndPasswordAsync(_registerViewModel.Email, password, _registerViewModel.Username);

                MessageBox.Show("Successfully registered!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                _loginNavigationService.Navigate();

            }
            catch (Exception)
            {
                MessageBox.Show("Registration failed. Please try again latter.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                throw;
            }

        }
    }
}
