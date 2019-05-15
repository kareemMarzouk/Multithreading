using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_programming3_kareem
{
        class Program
        {
            static void Main(string[] args)
            {
                CalculateAsync().Wait();    // Call async method
            }


            private static async Task CalculateAsync()
            {

            Console.WriteLine("x = (a^2 + b^2 + c^2)/(p^2 – q^2  + r^2)");

            Console.WriteLine("\nEnter a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEnter b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEnter c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEnter p: ");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEnter q: ");
            double q = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEnter r: ");
            double r = Convert.ToDouble(Console.ReadLine());

            Task<double> firstTask = Calculate(a, b, c);
                Task<double> secondTask = Calculate2(p, q, r);
                await Task.WhenAll(firstTask, secondTask);  // waits for specified tasks to complete
                double result = firstTask.Result / secondTask.Result;

                Console.WriteLine("\nx = " + result);  //display result
            }

            static Task<double> Calculate(double a, double b, double c)
            {
                return Task.Run<double>(() =>
                {
                    return (Math.Pow(a, a)) + (Math.Pow(b, b)) + (Math.Pow(c, c));  // your calculation
                });
            }

        static Task<double> Calculate2 (double p, double q, double r)
        {
            return Task.Run<double>(() =>

                {
                    return (Math.Pow(p, p)) - (Math.Pow(q, q)) + (Math.Pow(r, r));
                });
        }


        }
    }