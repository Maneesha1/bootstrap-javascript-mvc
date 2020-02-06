using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deligates
{
    public delegate void deligatePointer();//delegate def
    public delegate double areaPointer(double d);
    public delegate areaPointer(double x);
    class Program
    {

        static void Main(string[] args)
        {
            //Console.WriteLine("hii");
            //Program p = new Program();
            ////Calculate c = new Calculate();

            ////deligatePointer mydeligate = new deligatePointer(p.print);
            //deligatePointer mydeligate = p.print;
            //mydeligate += p.display;
            //mydeligate();
            //mydeligate -= p.print;
            //mydeligate();
            //areaPointer ptr = Calculate.area;//create delegate obj

            //ptr += Calculate.dis;
            //double area = ptr(90);
            //Console.WriteLine(area);
            //Console.ReadLine();
            areaPointer ptr = new areaPointer(delegate (double r) { return 3.14 * r * r; });
            double area = ptr(12);
            Console.WriteLine(area);
        }
        //public void print()
        //{
        //    Console.WriteLine("manu0");
        //}
        //public void display()
        //{
        //    Console.WriteLine("multicast");
        //}
    }
}
