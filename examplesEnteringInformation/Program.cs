using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examplesEnteringInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = Console.ReadLine();

            Console.WriteLine("Привет! Как тебя зовут?"); // выводим на экран переданный текст

            string name = Console.ReadLine(); // пользователь вводит свое имя. Сохраняем в переменную "name"

            Console.WriteLine("Привет, " + name); // приветствуем пользователя. Вместо переменной подставиться его значение, то есть то что ввел пользователь.
            Console.ReadKey();
        }
    }
}