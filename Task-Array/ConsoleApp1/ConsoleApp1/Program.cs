using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //int[] arr = { 1,2,3,4,5,6,7,8,9,10};
            //for (int i = arr.Length-1; i >=0; i--)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            #endregion

            #region
            //int[] arr1 = { 2, 6, 4, 3, 8, 11, 9, 5, 12, 14, 13, 1, 7, 10 };
            //int[] arr2 = { 15, 16, 17, 18 };
            //int length = arr1.Length + arr2.Length;
            //int[] res = new int[length];

            //for (int i = 0; i < res.Length; i++)
            //{
            //    if (i < arr1.Length)
            //    {
            //        res[i] = arr1[i];
            //    }
            //    else
            //    {
            //        res[i] = arr2[i - arr1.Length];
            //    }
            //}
            //Array.Sort(res);
            //for (int i = res.Length-1; i >=0; i--)
            //{
            //    Console.WriteLine(res[i]);
            //}
            #endregion

            #region
            //int[] arr = {23, 1, 7, 5, 43, 17, 31, 41, 99, 43, 57, 67, 71, 79, 83, 95 };
            //int a = 0;
            //int b = 0;
            //int num1 = arr[a];
            //int num2 = arr[b];
            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    if (num1 < arr[i + 1])
            //    {
            //        num1 = arr[a];
            //    }
            //    else
            //    {
            //        a = i + 1;
            //        num1 = arr[a];
            //    }

            //    if (num2 < arr[i + 1])
            //    {
            //        b = i + 1;
            //        num2 = arr[b];
            //    }
            //    else
            //    {
            //        num2 = arr[b];
            //    }
            //}
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);
            #endregion

            #region
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};

            //int a = 0;
            //int b = 0;
            //int[] arrTek = new int[0];
            //int[] arrCut = new int[0];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Array.Resize(ref arrTek, b + 1);
            //    Array.Resize(ref arrCut, a + 1);
            //    if (arr[i] % 2 == 0)
            //    {
            //        arrCut[a] = arr[i];
            //        a++;
            //    }
            //    else
            //    {
            //        arrTek[b] = arr[i];
            //        b++;
            //    }
            //}
            //Array.Resize(ref arrTek, b);
            //Array.Resize(ref arrCut, a);

            //foreach (var item in arrTek)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine("\n");
            //foreach (var item in arrCut)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion
        }
    }
}