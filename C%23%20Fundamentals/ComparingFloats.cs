using System;
using System.Globalization;

namespace _13.ComparingFloats
{
    class CompareFloats
    {
        static void Main(string[] args)
        {


            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double difference = Math.Abs(a - b);
            double eps = 0.000001;
            bool isEqual = true;

            if (difference >= eps)
            {
                isEqual = false;
            }

            string output = "false";

            if (isEqual)
            {
                output = "true";
            }

            Console.WriteLine(output);
        }
    }
}