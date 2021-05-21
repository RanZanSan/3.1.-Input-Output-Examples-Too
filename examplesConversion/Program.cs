using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examplesConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = Console.ReadLine();
            //int a = Convert.ToInt32(s);

            //int a = Convert.ToInt32(Console.ReadLine()); // Ввели число

            string s = Console.ReadLine();
            int number = Convert.ToInt32(s); // целое число
            double d = Convert.ToDouble(s); // вещественное число
            char character = Convert.ToChar(s); // в символ
            bool boolean = Convert.ToBoolean(s); // в логический тип данных

            Console.ReadKey();
        }
    }
}