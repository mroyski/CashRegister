using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister
{
    public class Steak : Meat
    {
        public Steak()
        {
            Name = "Steak";
            HasWeight = true;
            Price = 8.00M;
            OnSale = false;
            GetWeight();
        }
    }
}
