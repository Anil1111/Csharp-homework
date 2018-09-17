using System;

namespace program3
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNum = 100;
            Console.Write("2-100以内的素数有:");
            for (int num = 2; num <= maxNum; num++)
            {
                for(int div = 2; div <= num; div++)
                {
                    if (num % div == 0)
                    {
                        if(num == div)
                        {
                            Console.Write(" " + num);
                        }
                        if (num != div) break;
                    }
                }
            }
        }
    }
}
