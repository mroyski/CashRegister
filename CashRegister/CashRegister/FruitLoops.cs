using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister
{
    public class FruitLoops : Cereal
    {
        public FruitLoops()
        {
            Name = "Fruit Loops";
            HasWeight = false;
            Price = 3.50M;
            OnSale = true;
        }
    }
}
