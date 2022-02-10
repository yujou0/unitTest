using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTest;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            int num1 = 10, num2 = 20;
            int result = order.Add(num1, num2);
            Console.WriteLine(result);
        }
    }
}
