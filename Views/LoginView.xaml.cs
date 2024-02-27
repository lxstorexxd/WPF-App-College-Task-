using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using TestProject.Models;
using TestProject.ViewModels;
using TestProject.Views;


namespace TestProject.Views
{
    /// <summary>
    /// Логика взаимодействия для LoginView.xaml
    /// </summary>
    public partial class LoginView : Page
    {
        private LoginViewModel _viewModel;

        public LoginView()
        {
            InitializeComponent();
            _viewModel = new LoginViewModel();
            DataContext = _viewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (_viewModel.LoginCommand.CanExecute(null))
            {
                _viewModel.LoginCommand.Execute(null);

                if (!_viewModel.IsAuthenticated)
                {
                    MessageBox.Show("Authentication failed. Please check your credentials.");
                }
            }
        }

        private void PasswordChanged_Password(object sender, RoutedEventArgs e)
        {
            if (DataContext is LoginViewModel viewModel)
            {
                viewModel.Password = (sender as PasswordBox)?.SecurePassword;
            }
        }

    }
}


