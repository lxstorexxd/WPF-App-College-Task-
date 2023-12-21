using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public DateTime Expiration { get; set; }

        public double Price { get; set; }
        public int Count { get; set; }
        public double Weight { get; set; }
    }
}
