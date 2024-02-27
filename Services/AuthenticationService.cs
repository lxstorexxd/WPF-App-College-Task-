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
            new User { UserId = 1, Username = "bigbolt", Password = "558337", FirstName = "Даня", LastName = "", BirthDate = new DateTime(2005, 1, 1), Role = "Директор", AvatarPath = "/assets/admin.jpg" },
            new User { UserId = 5, Username = "gohufreilagrau-3818", Password = "cl12345", FirstName = "Фролов", LastName = "Андрей Иванович", BirthDate = new DateTime(2001, 7, 14), Role = "Администратор", AvatarPath = "/assets/default-avatar.jpeg" },
            new User { UserId = 6, Username = "xawugosune-1385", Password = "cl12346", FirstName = "Николаев", LastName = "Даниил Всеволодович", BirthDate = new DateTime(2001, 2, 10), Role = "Официант", AvatarPath = "/assets/default-avatar.jpeg" },
            new User { UserId = 7, Username = "satrahuddusei-4458", Password = "cl12347", FirstName = "Снегирев", LastName = "Макар Иванович", BirthDate = new DateTime(1998, 5, 21), Role = "Повар", AvatarPath = "/assets/default-avatar.jpeg" },
            new User { UserId = 8, Username = "boippaxeufrepra-7093", Password = "cl12348", FirstName = "Иванов", LastName = "Иван Ильич", BirthDate = new DateTime(1998, 10, 1), Role = "Повар", AvatarPath = "/assets/default-avatar.jpeg" },
            new User { UserId = 9, Username = "zapramaxesu-7741", Password = "cl12349", FirstName = "Филиппова", LastName = "Анна Глебовна", BirthDate = new DateTime(1976, 5, 31), Role = "Повар", AvatarPath = "/assets/default-avatar.jpeg" },
            new User { UserId = 10, Username = "rouzecroummegre-3899", Password = "cl12350", FirstName = "Иванов", LastName = "Михаил Владимирович", BirthDate = new DateTime(1985, 11, 4), Role = "Официант", AvatarPath = "/assets/default-avatar.jpeg" },
            new User { UserId = 11, Username = "ziyeuddocrabri-4748", Password = "cl12351", FirstName = "Власов", LastName = "Дмитрий Александрович", BirthDate = new DateTime(1998, 8, 17), Role = "Официант", AvatarPath = "/assets/default-avatar.jpeg" },
            new User { UserId = 12, Username = "ketameissoinnei-1951", Password = "cl12352", FirstName = "Серова", LastName = "Екатерина Львовна", BirthDate = new DateTime(1984, 10, 24), Role = "Администратор", AvatarPath = "/assets/default-avatar.jpeg" },
            new User { UserId = 13, Username = "yipraubaponou-5849", Password = "cl12353", FirstName = "Борисова", LastName = "Ирина Ивановна", BirthDate = new DateTime(1976, 10, 14), Role = "Официант", AvatarPath = "/assets/default-avatar.jpeg" },
        };

        private static List<Product> _product = new List<Product>
        {
            new Product { ProductId = 1, Name = "Яблоко красное", Expiration = DateTime.Now.AddDays(7), Price = 20, Count = 20, Weight = 8 },
            new Product { ProductId = 2, Name = "Паштет из свинины", Expiration = DateTime.Now.AddMonths(1), Price = 200, Count = 34, Weight = 0.4 },
            new Product { ProductId = 3, Name = "Мясо говядина", Expiration = DateTime.Now.AddDays(5), Price = 1200, Count = 3, Weight = 20 },
            new Product { ProductId = 4, Name = "Помидор черри", Expiration = DateTime.Now.AddDays(14), Price = 400, Count = 50, Weight = 0.2 },
            new Product { ProductId = 5, Name = "Крупа гречневая", Expiration = DateTime.Now.AddMonths(3), Price = 300, Count = 20, Weight = 4 },
            new Product { ProductId = 6, Name = "Молоко", Expiration = DateTime.Now.AddDays(3), Price = 300, Count = 5, Weight = 1 },
            new Product { ProductId = 7, Name = "Соус сырный", Expiration = DateTime.Now.AddMonths(2), Price = 150, Count = 50, Weight = 0.1 },
            new Product { ProductId = 8, Name = "Чеснок", Expiration = DateTime.Now.AddMonths(2), Price = 100, Count = 48, Weight = 0.3 },
            new Product { ProductId = 9, Name = "Мясо свинина (заморозка)", Expiration = DateTime.Now.AddMonths(2), Price = 300, Count = 12, Weight = 15 },
            new Product { ProductId = 10, Name = "Соль", Expiration = DateTime.Now.AddMonths(4), Price = 450, Count = 50, Weight = 0.2 },
            new Product { ProductId = 11, Name = "Огурец", Expiration = DateTime.Now.AddMonths(2), Price = 300, Count = 25, Weight = 0.3 },
            new Product { ProductId = 12, Name = "Картофель", Expiration = DateTime.Now.AddMonths(2), Price = 700, Count = 50, Weight = 0.1 },
            new Product { ProductId = 13, Name = "Картофельное пюре растворимое", Expiration = DateTime.Now.AddYears(1), Price = 1200, Count = 34, Weight = 1 },
        };

        private static List<EmployeeShift> _employeeShifts = new List<EmployeeShift>
        {
            new EmployeeShift { ShiftId = 1, EmployeeName = "9ч", ShiftDate = new DateTime(2022, 3, 12, 9, 10, 0), Revenue = 80000 },
            new EmployeeShift { ShiftId = 2, EmployeeName = "10ч", ShiftDate = new DateTime(2022, 3, 13, 10, 10, 0), Revenue = 18900 },
            new EmployeeShift { ShiftId = 3, EmployeeName = "11ч", ShiftDate = new DateTime(2022, 3, 14, 11, 10, 0), Revenue = 45670 },
            new EmployeeShift { ShiftId = 4, EmployeeName = "12ч", ShiftDate = new DateTime(2022, 3, 15, 12, 10, 0), Revenue = 45328 },
            new EmployeeShift { ShiftId = 5, EmployeeName = "13ч", ShiftDate = new DateTime(2022, 3, 16, 13, 10, 0), Revenue = 79000 },
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

        public static List<EmployeeShift> GetEmployeeShifts()
        {
            return _employeeShifts;
        }
    }
}

