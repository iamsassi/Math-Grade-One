using System;

namespace Math_Grade_One
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to 'Exiting Math' for grade one students ");
            Console.Write("What is your name? ");
            string Fname = Console.ReadLine();

            Menu user = new Menu(Fname, 0, 3, 0, 0, 0);

            Console.ReadLine();
        }
    }
}
