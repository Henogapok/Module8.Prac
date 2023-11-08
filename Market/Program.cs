using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Service serv = new Service();
            serv.addToCart(1000, "Sandwich");
            serv.addToCart(500, "Coke");
            serv.addToCart(1000, "Water");
            serv.showCart();
            Console.WriteLine("Total price: {0}", serv.Buy());
        }
    }
}
