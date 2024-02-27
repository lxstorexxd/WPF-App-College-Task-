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
    public class ProductListViewModel : ObservableObject
    {
        private ObservableCollection<Product> _products;

        public ObservableCollection<Product> Products
        {
            get { return _products; }
            set
            {
                if (_products != value)
                {
                    _products = value;
                    OnPropertyChanged(nameof(Products));
                }
            }
        }
        public ProductListViewModel()
        {
            Products = new ObservableCollection<Product>(AuthenticationService.GetProducts());
        }
    }
}
