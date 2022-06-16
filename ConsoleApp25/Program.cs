using System;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год:");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)) Console.WriteLine("Год високосный");
            else Console.WriteLine("Год не високосный");
        }
    }
}
