﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister
{
    public interface IItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

    }
}
