using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Delegate
    {
        delegate double Operation(double x);
        Operation[] operations = { Add, Multiply, Divide, Substract, Cube, Sqrt };
        public void Print(double x)
        {
            for (int i = 0; i < operations.Length; i++)
            {
                Console.WriteLine(operations[i](x));
            }
        }
        static double Add(double x) => x + x;
        static double Multiply(double x) => Math.Round(x * x, 2);
        static double Substract(double x) => x - x;
        static double Divide(double x) => x / x;
        static double Cube(double x) => Math.Round(x * x * x, 2);
        static double Sqrt(double x) => Math.Round(Math.Sqrt(x), 2);
    }
}
