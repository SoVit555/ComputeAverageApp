using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ComputeAverageApp
{
    internal class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            double average = 0;
            Console.WriteLine("Enter 5 gradee separated by new line:");
            for (int i = 0; i < 5; i++) 
            {
                average += Convert.ToDouble(Console.ReadLine());
            }
            average /= 5;
            Console.WriteLine("The average is " + average + " and round off to "+ Math.Round(average));
            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
