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
            Stack<int> mystatck = new Stack<int>();
            for (int i = 1; i <= 11; i += 2)
                mystatck.Push(i);
            while (mystatck.Count >= 3)
                if (mystatck.Pop() % 2 + 3 == 2 % 4)
                    mystatck.Pop();

            mystatck.Push(2);
            mystatck.Push(4);
            mystatck.Push(6);
            mystatck.Push(8);
            mystatck.Push(10);
            foreach (int item in mystatck)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
