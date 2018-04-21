using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    class LinkedListStack<t>
    {
        LinkedList<t> list;
        public LinkedListStack()
        {
            list = new LinkedList<t>();
        }
        public void push(t item)
        {
            list.AddLast(item);
        }
        public t pop()
        {
           
            t item = list.Last.Value;
            
            list.Remove(list.Find(list.Last.Value));
            //or
            //list.RemoveLast();
            return item;
        }
        public t peek()
        {
            t item = list.Last.Value;
            return item;
        }
        public int count()
        {
            return list.Count;
        }
        // or by properety
        //public int countP
        //{ get { return list.Count; } }

    }

    class LinkedListQueue<t>
    {
        LinkedList<t> list;
        public LinkedListQueue()
        {
            list = new LinkedList<t>();
        }
        public void Enqueue(t item)
        {
            list.AddLast(item);
        }

        public t Dequeue()
        {

            t item = list.First.Value;

            list.Remove(list.Find(list.First.Value));
            //or
           // list.RemoveFirst();
            return item;
        }
        public t peek()
        {
            t item = list.First.Value;
            return item;
        }
        public int count()
        {
            return list.Count;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            
            LinkedListStack<string> name = new LinkedListStack<string>();
            name.push("kinan");
            name.push("shaza");
            name.push("zaino");

            while (name.count() >0)
            {

                Console.WriteLine(name.peek());
                name.pop();
                //or
                //Console.WriteLine(name.pop());
            }
            Console.WriteLine("*****************");
            LinkedListQueue<string> nameQ = new LinkedListQueue<string>();
            nameQ.Enqueue("kinan");
            nameQ.Enqueue("shaza");
            nameQ.Enqueue("zaino");

            while (nameQ.count() > 0)
            {

                Console.WriteLine(nameQ.peek());
                nameQ.Dequeue();
                //or
                //Console.WriteLine(name.pop());
            }
            Console.ReadKey();

        }
    }
}
