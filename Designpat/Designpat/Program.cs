
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designpat
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singl fromemp = new Singl();
            Singl fromemp = Singl.GetInstance;
            fromemp.printdetails("emp");
            //fromemp.printdetails("hloo");
            //Singl fromstu = new Singl();
            Singl fromstu = Singl.GetInstance;
            fromstu.printdetails("manu");
            Console.ReadKey();
        }
    }
}
