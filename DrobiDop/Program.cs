using System;

namespace DrobiDop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var f1 = new Drobi(4, 11);
            var f2 = new Drobi(6, 9);

            var f3 = f1 + f2;

            Console.WriteLine($"{f1} + {f2} = {f3}");
            Console.ReadLine();
        }
    }
}
