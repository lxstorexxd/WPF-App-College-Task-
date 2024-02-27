using System.Diagnostics;
using System.Net;
using System.Security;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TestProject.Helpers;
using TestProject.Models;
using TestProject.Services;
using TestProject.Views;

namespace TestProject.ViewModels
{
    public class LoginViewModel : ObservableObject
    {
        private string _username;
        private SecureString _password = new SecureString();
        private bool _isAuthenticated;
        private User _authenticatedUser;

        public string Username
        {
            get { return _username; }
            set
            {
                if (_username != value)
                {
                    _username = value;
                    OnPropertyChanged(nameof(Username));
                }
            }
        }

        public SecureString Password
        {
            get { return _password; }
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged(nameof(Password));
                }
            }
        }

        public bool IsAuthenticated
        {
            get { return _isAuthenticated; }
            set
            {
                if (_isAuthenticated != value)
                {
                    _isAuthenticated = value;
                    OnPropertyChanged(nameof(IsAuthenticated));
                }
            }
        }

        public ICommand LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(Login, CanLogin);
        }

        private bool CanLogin(object parameter)
        {
            return !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(new NetworkCredential("", Password).Password);
        }

        private void Login(object parameter)
        {
            _authenticatedUser = AuthenticationService.Authenticate(Username, new NetworkCredential("", Password).Password);

            if (_authenticatedUser != null)
            {
                IsAuthenticated = true;
                OpenProfile();
            }
            else
            {
                IsAuthenticated = false;
            }
        }
        private void OpenProfile()
        {
            ProfileViewModel profileViewModel = new ProfileViewModel();
            profileViewModel.LoadUserData(_authenticatedUser);

            // Проверяем, является ли текущее окно страницей (как это может быть в WPF)
            if (Application.Current.MainWindow is MainWindow mainWindow)
            {
                // Получаем Frame из MainWindow и используем NavigationService для перехода к новой странице
                if (mainWindow.MainFrame != null)
                {
                    mainWindow.MainFrame.Navigate(new ProfileView { DataContext = profileViewModel });
                }
            }
        }
    }
}
