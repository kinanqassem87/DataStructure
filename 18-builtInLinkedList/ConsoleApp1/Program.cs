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
            string[] name = { "kinan", "shaza", "zaino" };
            //put element of array in the linked list
            LinkedList<string> lk = new LinkedList<string>(name);

            LinkedListNode<string> rayan = new LinkedListNode<string>("rayan");
            lk.AddLast(rayan);
            //or
            // lk.AddLast("rayan");

            lk.AddFirst("jaber");

            lk.AddAfter(lk.Find("shaza"), "elham");//or by node
            lk.AddBefore(lk.Find("kinan"), "mahmoud");//or by node
            lk.Remove(rayan);//or by value and return true or false
            foreach (string item in lk)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(lk.Contains("zaino"));
            Console.ReadKey();
        }
    }
}
