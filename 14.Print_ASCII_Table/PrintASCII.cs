namespace _14.Print_ASCII_Table
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    namespace PrintASCII
    {
        class PrintASCII
        {

            static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8;

                for (int i = 0; i <= 255; i++)
                {
                    Console.WriteLine("{0}={1}", i, (char)i); 
                }
            }
        }

    }
}
