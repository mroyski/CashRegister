using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister
{
    public class Cheerios : Cereal
    {
        public Cheerios()
        {
            Name = "Cheerios";
            HasWeight = false;
            Price = 1.79M;
            OnSale = true;
        }
    }
}
