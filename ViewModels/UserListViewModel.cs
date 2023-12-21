using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Helpers;
using TestProject.Models;
using TestProject.Services;

namespace TestProject.ViewModels
{
    public class UserListViewModel : ObservableObject
    {
        private ObservableCollection<User> _users;

        public ObservableCollection<User> Users
        {
            get { return _users; }
            set
            {
                if (_users != value)
                {
                    _users = value;
                    OnPropertyChanged(nameof(Users));
                }
            }
        }

        public UserListViewModel()
        {
            Users = new ObservableCollection<User>(AuthenticationService.GetUsers());
        }
    }
}
