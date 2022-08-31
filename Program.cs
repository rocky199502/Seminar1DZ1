using System;

namespace DZseminar1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            string first = Console.ReadLine();
            int number1 = int.Parse(first);
            Console.WriteLine("Введите второе число:");
            string second = Console.ReadLine();
            int number2 = int.Parse(second);
            if (number1>number2)
            {
                Console.WriteLine("Большее число: "+number1);
                Console.WriteLine("Меньшее число: "+number2);
            }
            else 
            {
                Console.WriteLine("Большее число: "+number2);
                Console.WriteLine("Меньшее число: "+number1);
            }
        }
    }
}
