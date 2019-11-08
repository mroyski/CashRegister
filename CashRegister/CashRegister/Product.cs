using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister
{
    public class Product : IWeight, IItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool OnSale { get; set; }
        public bool HasWeight { get; set; }
        public decimal Weight { get; set; }

        public void GetWeight()
        {
            Console.WriteLine("Enter the weight");
            var weight = Console.ReadLine();
            Weight = Convert.ToDecimal(weight);
            Price = Weight * Price;
        }
    }
}
