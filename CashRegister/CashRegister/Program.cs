using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal total;
            var cart = new List<Product>();
            var exit = false;
            while (exit == false)
            {
                total = 0;
                Console.WriteLine("Scanned Items:");
                foreach (var item in cart)
                {
                    Console.WriteLine($"{item.Name} : {item.Price}");
                    total += item.Price;
                }
                Console.WriteLine($"Total: {total}");
                Console.WriteLine("Scan an item");
                Console.WriteLine("a: apple\nb: cheerios\nc: chicken\nd:exit");
                var scan = Console.ReadKey().KeyChar;
                switch (scan)
                {
                    case 'a':
                        var apple = new Apple();
                        apple.GetWeight();
                        cart.Add(apple);
                        break;
                    case 'b':
                        cart.Add(new Cheerios());
                        break;
                    case 'c':
                        var chicken = new Chicken();
                        chicken.GetWeight();
                        cart.Add(chicken);
                        break;
                    case 'd':
                        exit = true;
                        break;
                    default:
                        break;
                }
                Console.Clear();

            }

        }
    }
}
