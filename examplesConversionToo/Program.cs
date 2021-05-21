using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examplesConversionToo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine()); // ввели первое число
            int b = Convert.ToInt32(Console.ReadLine()); // ввели второе число
            int c = a + b; // посчитали сумму и записали в переменную целого типа "c"

            Console.WriteLine(c); // вывели значение переменной "с". 
            Console.ReadKey();

            //Нужно понимать, что можно было вывести и сразу сумму, то есть написать
            //Console.WriteLine(a + b);
        }
    }
}