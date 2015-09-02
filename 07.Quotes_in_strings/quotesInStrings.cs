namespace _07.Quotes_in_strings
{
    using System;

    class quotesInStrings
    {
        static void Main(string[] args)
        {
            string a = "The \"use\" of quotations causes difficulties.";
            Console.WriteLine(a);
            string b = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(b);
        }
    }
}
