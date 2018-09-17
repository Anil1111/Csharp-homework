using System;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNum;
            string sTemp;
            Console.WriteLine("Please input a int number:");
            sTemp = Console.ReadLine();
            iNum = int.Parse(sTemp);

            int n = iNum;
            Console.Write(iNum + "的所有素数因子是:");
            for (int i = 2; i <= iNum; i++)
            {
                while (n % i == 0)
                {
                    n = n / i;
                    Console.Write(" " + i);
                }
            }
        }
    }
}
