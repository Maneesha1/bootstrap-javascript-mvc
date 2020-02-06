using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public static int sum(int a,ref int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            int a = 12;
            int b = 13;
            Console.WriteLine(sum(a, ref b));
        }
    }
}
