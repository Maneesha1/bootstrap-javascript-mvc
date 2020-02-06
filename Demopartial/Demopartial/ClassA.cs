using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demopartial
{
    partial class ClassA
    {
        partial void setData()
        {
            Console.WriteLine("calssa");
    //        setData();
        }
    }
}
