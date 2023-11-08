using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Market
{
    public class Cart
    {
        List<Product> products = new List<Product>();
        private double totalPrice = 0;
        

        public void addProduct(int price, string naming)
        {
            products.Add(new Product(price, naming));
        }
        public Product this[int index]
        {
            get 
            {
                return products[index]; 
            }
        }
        public int getCount()
        {
            return products.Count;
        }
        
    }
}
