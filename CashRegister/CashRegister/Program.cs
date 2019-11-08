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
                    Console.WriteLine($"{item.Name} : ${item.Price}");
                    total += item.Price;
                }
                Console.WriteLine();
                Console.Write($"Total: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"${total}\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Scan an item");
                Console.WriteLine("a: apple\nb: banana\nc: chicken\nd: steak\ne: cheerios\nf: fruit loops\ng: enter PLU\nx: exit");
                var scan = Console.ReadKey().KeyChar;
                switch (scan)
                {
                    case 'a':
                        cart.Add(new Apple());
                        break;
                    case 'b':
                        cart.Add(new Banana());
                        break;
                    case 'c':
                        cart.Add(new Chicken());
                        break;
                    case 'd':
                        cart.Add(new Steak());
                        break;
                    case 'e':
                        cart.Add(new Cheerios());
                        break;
                    case 'f':
                        cart.Add(new FruitLoops());
                        break;
                    case 'g':
                        Console.WriteLine("enter the plu\napple: 4130, banana: 4011");
                        var plu = Console.ReadLine();
                        if (plu == "4011")
                        {
                            cart.Add(new Apple());
                        }
                        else if (plu == "4130")
                        {
                            cart.Add(new Banana());
                        }
                        break;
                    case 'x':
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
