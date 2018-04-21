using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApp
{
    class Program
    {
        static bool isequal<t>(t x, t y)
        {
            if (x.ToString().Equals(y.ToString()))
                return true;
            else return false;
        }

        //can't use operation math like (+ - * /) in generic 
        //can't use generic for Arraylist built in c# that solve by another technique

        static void Main(string[] args)
        {
            int x = 5;
            int y = 5;
            Console.WriteLine(isequal<int>(x,y));
            Console.ReadKey();
        }
    }
}
