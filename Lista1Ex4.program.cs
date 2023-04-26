using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write("Digite o valor da altura do triângulo:");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da base do triângulo:");
            b = double.Parse(Console.ReadLine());

            c = (a * b) / 2;
            Console.WriteLine($"A área de um triângulo de altura {a} e base {b} é {c}.");

        }
    }
}
