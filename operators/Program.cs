using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            var quotient = a / b;
            var remainder = a % b;

            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder} ");

            int addition = a + b;
            Console.WriteLine(addition);

            int subtraction = a - b;
            Console.WriteLine(subtraction);

            var radius = 20;
            var pi = Math.PI;

            var areaOfCircle = pi * (radius * radius);

            Console.WriteLine($"the are aof a circle with a {radius} is {areaOfCircle}");


        }
    }
}
