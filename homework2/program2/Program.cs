using System;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int iMax, iMin, iAdd;
            float iAve;
            iMax = array[0];
            for (int i = 0; i < array.Length - 1; i++) 
            {
                if(array[i] < array[i + 1])
                {
                    iMax = array[i+1];
                }
            }
            iMin = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    iMin = array[i + 1];
                }
            }
            iAve = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                iAve = (iAve * (i + 1) + array[i + 1]) / (i + 2);
            }
            iAdd = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                iAdd = iAdd + array[i+1];
            }
            Console.Write("数组：");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.Write("\n");
            Console.Write("该数组的最大值是" + iMax + "，最小值是" + iMin + "，平均值是"
                + iAve + "，和是" + iAdd + "。");

        }
    }
}
