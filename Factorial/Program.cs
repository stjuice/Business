using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Enter the Number: ");
            number = int.Parse(Console.ReadLine());

            double fact = number;

            //for (var i = number - 1; i >= 1; i--)
            //{
            //    fact = fact * i;
            //}

            int  i= number - 1;
            Parallel.For(i, number, (i) => {

                for (i = number - 1; i >= 1; i--)
                {
                    fact = fact * i;
                }

            });
            
            Console.WriteLine("\nFactorial of Given Number is: " + fact);
            Console.ReadLine();
        }
    }
}
