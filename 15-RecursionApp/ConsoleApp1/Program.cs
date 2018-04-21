using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int fib(int n)
        {

            // 1,1,2,3,5,8,13,21,...

            // or 0,1,1,2,3,5,8,13,21,...
            if (n == 1) { return 0; }
            else if (n == 2) { return 1; }
            else return fib(n - 1) + fib(n - 2);
        }


        static bool find(int [] arr,int item,int index=0)
        {
            if (arr.Length - 1 == index)
            {
                if (arr[index] == item) { return true; }
                else { return false; }
            }
            else
            {
                if (arr[index] == item) { return true; }
                else { return find(arr, item, ++index); }
            }
        }

        static void PrintReserve(string text, int length)
        {
            if (length - 1 == 0)
            {
                Console.Write(text[0]);
            }
            else
            {
                Console.Write(text[length - 1]);
                PrintReserve(text, length - 1);
            }
        }

        static int MaxInStack(Stack<int> s)
        {
            if (s.Count == 1)
            {
                return s.Pop();
            }
            else
            {
                return Math.Max(s.Pop(), MaxInStack(s));
            }
        }

        static void Main(string[] args)
        {
            /*
            Console.WriteLine("input th enumber to calculate fibonachi");
            int input =fib(Convert.ToInt16(Console.ReadLine()));
            Console.WriteLine("input = " + input);
            Console.ReadLine();*/

            /*
            int[] arr = {5,8,6,9,4,21 };
            Console.WriteLine(find(arr, 0));
            Console.ReadKey();
            */

            /*
            string text = "Hello world";
            PrintReserve(text, text.Length);
            Console.ReadKey();
            */
            Stack<int> s = new Stack<int>();
            s.Push(5);
            s.Push(19);
            s.Push(8);
            s.Push(13);
            s.Push(10);

            Console.WriteLine(MaxInStack(s));
            Console.ReadKey();

        }
    }
}
