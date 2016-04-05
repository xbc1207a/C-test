using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10, number2 = 100, total = 0, temp = 0;
            Fizz f = new Fizz();

            Console.WriteLine("number1+number2={0}", number1 + number2);
            Console.ReadKey();

            for(int i = 0; i < 100; i = i + 1)
            {
                f.AddANumber(i);
            }

            temp = f.GetOneNumber();
            while (temp != -1)
            {
                total = total + temp;
                temp = f.GetOneNumber();
            }
            Console.WriteLine("total=" + total);
            Console.ReadKey();
        }
    }
}
