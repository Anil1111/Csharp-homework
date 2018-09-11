using System;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            double dNum1 = 0;
            double dNum2 = 0;
            string s = "";
            Console.WriteLine("Please input a number:");
            s = Console.ReadLine();
            dNum1 = double.Parse(s);
            Console.WriteLine("Please input a number again:");
            s = Console.ReadLine();
            dNum2 = double.Parse(s);
            Console.WriteLine("The result of the multiplication of these two numbers is:" + (dNum1 * dNum2));
        }
    }
}