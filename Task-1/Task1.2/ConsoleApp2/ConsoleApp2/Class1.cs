using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class1
    {
        public void Method()
        {
            int[] arr = {4,3,2,8,3,2,6,8,2};
            int a = 0;
            int num = arr[a];
            for (int i = 0; i < arr.Length-1; i++)
            {
                if(num <= arr[i + 1])
                {
                    num = arr[a];
                }
                else
                {
                    a=i+1;
                    num = arr[a];
                }
            }
            Console.WriteLine("My number : " + num+"\n"+"First Index : " + a);
        }
    }
}
