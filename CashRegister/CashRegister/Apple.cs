using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister
{
    public class Apple : Produce
    {
        public Apple()
        {
            Name = "Apple";
            Code = "4130";
            HasWeight = true;
            Price = 1.79M;
            OnSale = false;
        }
    }
}
