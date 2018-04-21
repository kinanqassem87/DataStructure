using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamicVarType
{
    class Program
    {

        //solved by dynamic not by generic 
        static dynamic sum(dynamic x, dynamic y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {


            //dynamic example
            dynamic x = 1;
            Console.WriteLine(x);
             x = "Hellow";
            Console.WriteLine(x);
            x = new int[] {1,2,3 };
            foreach (int item in x)
            {
                Console.WriteLine(item);
            }

            x = DateTime.Now;
            int x1, x3;
            x1 = x3 = 10;

            //call method sum
            Console.WriteLine(sum(x1, x3));
            Console.WriteLine("**************\n");
            Console.WriteLine(x);

            //var type example
            //get its type from right side variable and can't change it later like dynamic
            //it's help me when retune unknown value from some namespeace so I store return value in var 

            //can use var only in the method not in the reference like sum(var x, var y){} that error
            var x2 = 5;
            var d = DateTime.Now;
            var s = "kinan";
            var a = new int[] {1,2,3,4,5 };

            //can't use this
            //var r; because there isn't right side value to define type for var
            Console.WriteLine(x2 + "\n" + d + "\n" + s + "\n" + a[1]);

            Console.ReadKey();
        }
    }
}
