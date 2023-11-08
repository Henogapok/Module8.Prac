using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    public class Product
    {
        private double Price { get; set; }
        private string Naming { get; set; }
        
        public Product(double Price, string Naming)
        {
            this.Price = Price;
            this.Naming = Naming;
        }
        public double getPrice()
        {
            return Price;
        }
        public override string ToString()
        {
            string res = Naming + " " + Price;
            return res;
        }
    }
}
