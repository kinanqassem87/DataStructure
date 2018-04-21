using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //similar to Arraylist
            //all function of arraylist can emplement on List (add,remove,copy,sort,capacety,count,.....)
            //this is generic list 
            //this has binarysearch method as additional method

            List<int> number = new List<int>() {1,3,4,9,2,6 };
            // to use binary search you must sort it before
            foreach (int item in number)
            {
                Console.WriteLine(item);

            }
            number.Sort();
            Console.WriteLine("After sort");
            foreach (int item in number)
            {
                Console.WriteLine(item);
         
            }
            Console.WriteLine("location of item is: ");
            Console.WriteLine(number.BinarySearch(9));
            Console.ReadKey();

        }
    }
}
