using System;

namespace Checkout
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine("Unit\t | Unit Price\t | Special");
            Console.WriteLine("A\t | 50\t\t | 3 for 130");
            Console.WriteLine("B\t | 30\t\t | 2 for 45");
            Console.WriteLine("C\t | 20\t\t | max 6 items allowed");
            Console.WriteLine("D\t | 15\t\t | \t \n");

            Till testtill = new Till();

            Console.WriteLine("Please Enter Product Unit:");
            String productunit = Console.ReadLine().ToUpper();

            testtill.Scan(productunit);
            Console.WriteLine("Total: " + testtill.Total());

        }
    }
}
