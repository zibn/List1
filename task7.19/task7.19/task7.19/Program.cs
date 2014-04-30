using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7._19
{
    /// <summary>
    /// №7.19
    /// Проверить правильность расстановки скобок в строке S
    /// Если текст составлен правильно, то вывести 0; в противном случае вывести номер первой ошибочной скобки или –1, если в строке 
    /// недостаточно закрывающих скобок. 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter a string here: ");
            string s = Convert.ToString(Console.ReadLine());
            int k = BracketTestClass.BracketTest(s);
            Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}
