using System;

namespace lesson7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Введите своё имя:");
            name = Console.ReadLine();
            Console.WriteLine($" Привет, { name }! Для выхода из программы нажми любую клавишу!");
            Console.ReadLine();
        }
    }
}
