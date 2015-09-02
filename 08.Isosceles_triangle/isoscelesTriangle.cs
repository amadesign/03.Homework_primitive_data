namespace _08.Isosceles_triangle
{
    using System;

    using System.Text;

    class isoscelesTriangle
    {
        static void Main(string[] args)
        {
            int c = 0x00a9;
            char symbol = (char)c;
            Console.WriteLine(("   {0}"), symbol);
            Console.WriteLine(("  {0} {0}"), symbol);
            Console.WriteLine((" {0}   {0}"), symbol);
            Console.WriteLine(("{0} {0} {0} {0}"), symbol);
        }
    }
}
