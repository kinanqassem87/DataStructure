using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class bQueue <t>
    {
        // Generic not support Arraylist, but support List 
        private List<t> list;
        public bQueue()
        {
            list = new List<t>();
        }
        public void enqueue(t item)
        {
            list.Add(item);
        }
        public t dequeue()
        {
            t item = list[0];
            list.RemoveAt(0);
            return item;
        }
        public t peek()
        {
            return list[0];
        }
        public int Qcount
        {
            get { return list.Count; }
        }
        public void clear()
        {
            list.Clear();
        }
        public t[] toarray()
        {
            return list.ToArray();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            bQueue<int> qq = new bQueue<int>();
            qq.enqueue(1);
            qq.enqueue(6);
            qq.enqueue(7);
            qq.enqueue(5);
            int sum = 0;
            while (qq.Qcount > 0)
            {
                sum += qq.dequeue();
            }
            Console.WriteLine("sum = " + sum);

            // builtin queue in c#
            Queue<string> q = new Queue<string>();
            q.Enqueue("kinan");
            q.Enqueue("shaza");
            q.Enqueue("rayan");

            foreach (string item in q)
            {
                Console.WriteLine(item);
            }
            
            //or this way
           /* while (q.Count > 0)
            {
                Console.WriteLine(q.Dequeue());
            }*/

            Console.ReadKey();
        }
    }
}
