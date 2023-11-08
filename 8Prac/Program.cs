using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Prac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RangeOfArray arr = new RangeOfArray(6, 10);
            arr.showArr();
            int index = 0;
            Console.WriteLine("Введите индекс массива, который вы хотите получить: ");
            while(!Int32.TryParse(Console.ReadLine(), out index))
            {
                Console.WriteLine("Некорректный ввод");
            }
            Console.WriteLine(arr[index]);
        }
    }
}
