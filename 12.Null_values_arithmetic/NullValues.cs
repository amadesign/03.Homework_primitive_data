namespace _12.Null_values_arithmetic
{
    using System;

    class NullValues
    {
        static void Main(string[] args)
        {
            int? integerOne = null;
            Console.WriteLine(integerOne);
            integerOne = 7;
            Console.WriteLine(integerOne);
            double? doubleOne = null;
            doubleOne = 3.5;
            Console.WriteLine(doubleOne);
        }
    }
}
