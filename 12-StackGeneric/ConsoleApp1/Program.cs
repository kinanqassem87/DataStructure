using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        class Cstack <t>
        {
            int pindex;
            //can use arraylist not support generic you can use List
            //ArrayList list;

            List<t> list;
            public Cstack()
            {
                list = new List<t>();
                pindex = -1;
            }
            public void push(t item)
            {
                list.Add(item);
                ++pindex;
            }
            public t pop()
            {
                t item = list[pindex];
                list.RemoveAt(pindex);
                --pindex;
                return item;
            }
            public t peek()
            {
                return list[pindex];
            }
            public int count
            {
                //or list.count()
                get { return pindex + 1; }

            }
            public void clear()
            {
                list.Clear();
                pindex = -1;
            }
            public t[] toarray()
            {
                List<t> temparray = new List<t>(list);
                temparray.Reverse();
                return temparray.ToArray();


            }
        }
        static void Main(string[] args)
        {
            //builtin stack is support generic
            Stack<int> builtint = new Stack<int>();
            builtint.Push(5);
            builtint.Push(7);
            builtint.Push(9);
            int min = builtint.Peek();
            while (builtint.Count > 0)
            {
                min = Math.Min(min, builtint.Pop());
            }
            Console.WriteLine("min is : " + min);
            
            /* 
            Cstack<int> cs = new Cstack<int>();
            cs.push(1);
            cs.push(5);
            cs.push(3);
            int max = cs.peek();
            while (cs.count > 0)
            {
                max = Math.Max(max, cs.pop());
                
            }
            Console.WriteLine("max is : "+max);*/
            Console.ReadKey();
        }
    }
}
