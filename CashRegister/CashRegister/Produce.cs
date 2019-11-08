using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister
{
    public class Produce : Product, IWeight
    {
        public string Code { get; set; }
    }
}
