namespace _13.Comparing_floats
{
    using System;

    class ComparingFloats
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ënter two numbers:");
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            bool checkNumber = Math.Abs(numberOne - numberTwo) < eps;
            if (Math.Abs(numberOne - numberTwo) < eps)
            {
                Console.WriteLine(checkNumber);
            }
            else if (Math.Abs(numberOne - numberTwo) >= eps)
            {
                Console.WriteLine(checkNumber);
            }

        }

    }

}

