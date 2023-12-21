using System;
using System.Diagnostics;
using TestProject.Helpers;
using TestProject.Models;


namespace TestProject.ViewModels
{
    public class ProfileViewModel : ObservableObject
    {
        private string _firstName;
        private string _lastName;
        private DateTime _birthDate;
        private string _role;
        private string _avatarPath;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    OnPropertyChanged(nameof(FirstName));
                }
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (_lastName != value)
                {
                    _lastName = value;
                    OnPropertyChanged(nameof(LastName));
                }
            }
        }

        public DateTime BirthDate
        {
            get { return _birthDate; }
            set
            {
                if (_birthDate != value)
                {
                    _birthDate = value;
                    OnPropertyChanged(nameof(BirthDate));
                }
            }
        }

        public string Role
        {
            get { return _role; }
            set
            {
                if (_role != value)
                {
                    _role = value;
                    OnPropertyChanged(nameof(Role));
                }
            }
        }

        public string AvatarPath
        {
            get { return _avatarPath; }
            set
            {
                if (_avatarPath != value)
                {
                    _avatarPath = value;
                    OnPropertyChanged(nameof(AvatarPath));
                }
            }
        }

        public void LoadUserData(User user)
        {
            FirstName = user.FirstName;
            LastName = user.LastName;
            BirthDate = user.BirthDate;
            Role = user.Role;
            AvatarPath = user.AvatarPath;
            Debug.WriteLine($"Attempting to load image from path: {AvatarPath}");
        }
    }
}
