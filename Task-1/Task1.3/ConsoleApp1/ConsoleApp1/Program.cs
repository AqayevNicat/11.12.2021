using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 100,200,20,300,30,50 };
            int res1 = 0;
            int res2 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 100)
                {
                    res1 += arr[i];
                }
                else
                {
                    res2 += arr[i];
                }
            }
            if (res1 >= res2)
            {
                Console.WriteLine(res1-res2);
            }
            else
            {
                Console.WriteLine(res2-res1);
            }
        }
    }
}
