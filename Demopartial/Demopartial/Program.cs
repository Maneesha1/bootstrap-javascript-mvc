using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demopartial
{
    partial class ClassA
    {
        partial void setData();
        public void print()
        {
            Console.WriteLine("classAprinting");
            setData();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ClassA o = new ClassA();
            o.print();

        }
    }
}
