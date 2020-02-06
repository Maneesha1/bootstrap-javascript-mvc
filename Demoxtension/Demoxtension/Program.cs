using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoxtension
{
    static class StringHelper
    {//helper class must be static
        public static string FirstCaseChange(this string name)//this 
        {
            char[] input = name.ToCharArray();
            input[0] = Char.IsUpper(input[0]) ? char.ToLower(input[0]) : char.ToUpper(input[0]);
            return new String(input);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string name = "manu";
            Console.WriteLine(name.FirstCaseChange());
            var anonymousType = new { property1 = "hgt", property = 12, property3 = true };
            Console.WriteLine(anonymousType.GetType());
            Console.ReadLine();
        }
    }
}
