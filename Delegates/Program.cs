using System;

namespace Delegates
{
    class Program
    {

        static void Main()
        {
            Delegate delegates = new Delegate();
            Console.WriteLine("Enter a number with floating point");
            delegates.Print(double.Parse(Console.ReadLine()));

        }
    }
}
