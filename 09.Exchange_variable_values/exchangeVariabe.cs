namespace _09.Exchange_variable_values
{
    using System;

    class exchangeVariabe
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before:");
            int a = 5;
            int b = 10;
            Console.WriteLine("a={0}", a);
            Console.WriteLine("b={0}", b);
            Console.WriteLine("After:");
            b = b - a;
            a = b + a;
            Console.WriteLine("a={0}", a);
            Console.WriteLine("b={0}", b);
        }
    }
}
