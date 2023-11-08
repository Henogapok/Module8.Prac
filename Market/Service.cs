using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Market
{
    public class Service
    {
        private TimeSpan Time;
        Cart cart;
        private double totalPrice = 0;


        public Service()
        {
            cart = new Cart();
            Time = DateTime.Now.TimeOfDay;
        }

        public void addToCart(int price, string naming)
        {
            cart.addProduct(price, naming);
        }

        public bool isDiscount()
        {
            TimeSpan start = new TimeSpan(8, 0, 0);
            TimeSpan end = new TimeSpan(12, 0, 0);
            if (Time >= start && Time <= end) return true;
            else return false;
        }
        public double Buy()
        {
            for (int i = 0; i < cart.getCount(); i++)
            {
                totalPrice += cart[i].getPrice();
            }
            if (isDiscount()) totalPrice *= 0.95;
            return totalPrice;
        }
        public void showCart()
        {
            Console.WriteLine("Your cart is: ");
            for(int i = 0; i < cart.getCount(); i++)
                Console.WriteLine(cart[i].ToString());

        }
    }
}
