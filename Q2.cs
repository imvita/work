using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("輸入數字");
            int input = Console.ReadLine();
            int i;
            Vector a;
            int i3 = Math.Floor(input / 3);
            int i5 = Math.Floor(input/5);
            for (i=0; i<input; i++)
            {
                a[i] = i + 1;
                if (a[i] % 3 == 0 || a[i] % 5 == 0)
                {
                    a[i] = 0;
                }
                else if (i % 15 == 0)
                {
                    a[i] = i + 1;
                }
            }
            a.Replace("0","");
            Console.WriteLine(a);
            Console.Read();
        }
    }
}
