using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    class Cstack
    {
        int pindex;
        ArrayList list;
        public Cstack()
        {
            list = new ArrayList();
            pindex = -1;
        }
        public void push(object item)
        {
            list.Add(item);
            ++pindex;
        }
        public object pop()
        {
            object item= list[pindex];
            list.RemoveAt(pindex);
            --pindex;
            return item;
        }
        public object peek()
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
        public object[] toarray()
        {
            ArrayList temparray = new ArrayList(list);
            temparray.Reverse();
            return temparray.ToArray();

            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //stack is sequential list not driect access to any item
            //push: insert into top of stack
            //pop: remove and return top item in the stack
            //peek: return top item in the stack

            Cstack cs = new Cstack();
            cs.push(1);
            cs.push(2);
            cs.push(3);

            /* it gives a wrong result becuase count is change each iteration , that pop (return and remove)
             * so you can't use for for this state
             * so yau can solve it by declare variable as c=cs.count and make it the finish condition
            int c = cs.count;
            for (int i = 0; i < c; i++)
            {
                Console.WriteLine(cs.pop());
            }
            */

            //best choice
            while (cs.count > 0)
            {
                Console.WriteLine(cs.pop());
                
                //or
                //Console.WriteLine(cs.peek());
                //cs.pop();

            }
            
            Console.ReadKey();

        }
    }
}
