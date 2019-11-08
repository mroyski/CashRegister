using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister
{
    public class Banana : Produce
    {
        public Banana()
        {
            Name = "Banana";
            Code = "4011";
            HasWeight = true;
            Price = 1.59M;
            OnSale = false;
            GetWeight();
        }
    }
}
