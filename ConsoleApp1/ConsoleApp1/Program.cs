using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Введите первое слогаемое: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе слогаемое: ");
            Console.WriteLine("Сумма: " + (a+b));
        }
    }
}
