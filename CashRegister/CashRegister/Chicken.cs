using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister
{
    public class Chicken : Meat
    {
        public Chicken()
        {
            Name = "Chicken";
            HasWeight = true;
            Price = 3.00M;
            OnSale = true;
        }
    }
}
