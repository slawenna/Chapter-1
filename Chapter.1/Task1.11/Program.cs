using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How old are you?");

            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("After 10 years, you will be {0}", age + 10);
        }
    }
}
