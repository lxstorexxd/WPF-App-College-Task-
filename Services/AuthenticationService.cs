using System;
using System.Collections.Generic;
using System.Linq;
using TestProject.Models;

namespace TestProject.Services
{
    public static class AuthenticationService
    {
        private static List<User> _users = new List<User>
        {
            new User { UserId = 1, Username = "admin", Password = "admin", FirstName = "Михаил", LastName = "Белый", BirthDate = new DateTime(1990, 1, 1), Role = "Администратор", AvatarPath = "/assets/admin.jpg" },
            new User { UserId = 2, Username = "seller", Password = "seller", FirstName = "Seller", LastName = "User", BirthDate = new DateTime(1990, 1, 1), Role = "Продавец", AvatarPath = "/assets/default-avatar.png" },
            new User { UserId = 3, Username = "sasha2004", Password = "sasha2004", FirstName = "Сашка", LastName = "Круглый", BirthDate = new DateTime(2004, 5, 5), Role = "Пользователь", AvatarPath = "/assets/sasha2004.jpg" },
            new User { UserId = 4, Username = "vlad2004", Password = "vlad2004", FirstName = "Влад", LastName = "Попов", BirthDate = new DateTime(2004, 10, 14), Role = "Пользователь", AvatarPath = "/assets/vlad2004.png" },
        };
        private static List<Product> _product = new List<Product>
        {
            new Product { ProductId = 1, Name = "Яблоки", Expiration = new DateTime(2024, 01, 1), Price = 100, Count = 1, Weight = 1.3 },
            new Product { ProductId = 1, Name = "Яблоки", Expiration = new DateTime(2024, 01, 1), Price = 100, Count = 1, Weight = 1.3 },
            new Product { ProductId = 1, Name = "Яблоки", Expiration = new DateTime(2024, 01, 1), Price = 100, Count = 1, Weight = 1.3 },
        };
        public static User Authenticate(string username, string password)
        {
            System.Diagnostics.Debug.WriteLine($"Attempting authentication: {username}, {password}");

            User authenticatedUser = _users.FirstOrDefault(u =>
                string.Equals(u.Username, username, StringComparison.OrdinalIgnoreCase) &&
                u.Password == password);

            return authenticatedUser;
        }

        public static User GetUserByUsername(string username)
        {
            return _users.FirstOrDefault(u => u.Username == username);
        }

        public static List<User> GetUsers()
        {
            return _users;
        }

        public static List<Product> GetProducts()
        {
            return _product;
        }
    }
}

