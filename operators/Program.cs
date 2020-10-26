using System;

namespace operators
{
    class Program
    {
        public static double AreaofCircle( double radius)
        {
            double pi = 3.14;
            return pi * (radius * radius);
        }
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

            
         

            

            

            var i = 3;

            var j = 4;

            var k = ++i * j++;

            Console.WriteLine(k);

            var ab = 30;

            var ac = 40;

            var ad = ab >= ac && ac > ab;

            Console.WriteLine(ad);

            Console.WriteLine("What is the radius of the circle?");
            double radius = Convert.ToDouble(Console.ReadLine());
            var area = AreaofCircle(radius);
           

            Console.WriteLine($"the area of a circle with a {radius} is {area}");



            //--------------------------------------------------------------------


            bool shouldContinue = false;

            Console.WriteLine("Would you like to continue?");
            var answer = Console.ReadLine();

            if (answer.ToLower() == "yes"|| answer.ToLower() =="ok")
            {
                Console.WriteLine("Continue with program");
            }

            if (shouldContinue)
            {
                shouldContinue = true;
            }

            else
            {
                Console.WriteLine("End program");
            }





        }   
            
    }
}
