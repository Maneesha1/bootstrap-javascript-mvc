using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
       
       
        static void Main(string[] args)
        {
            Console.WriteLine("enter ur name");
            string name = Console.ReadLine();
            Console.WriteLine("enter ur graduate year");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("my nameis" + name + " year of graduation" + year);
        }
    }
}
