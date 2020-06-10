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
            string putin;
            string putout;
            int leng;
            Console.Write("輸入字串");
            putin = Console.ReadLine();
            leng = putin.Length;
            putout = null;
            int i;
            for (i=0; i<leng; i++)
            {
                putout += putin[leng-i-1];
            }
            Console.WriteLine("{0}",putout);
            Console.Read();
        }
    }
}
