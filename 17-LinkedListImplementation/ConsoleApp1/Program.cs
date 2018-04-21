using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Node
    {
        public object value;
        //this link is represent object of Node so we use link with type Node
        //this is object of Node
        public Node link;
        public Node(object value)
        {
            this.value = value;
        }
        public Node() { }
    }



    class AlinkedList
    {
        private Node header;
        public AlinkedList()
        {
            header = new Node("header");
        }

        public void addNode(object value)
        {
            //Don't use header becuase I need second time so,it must keep in the first node
            Node p = header;
            while (p.link != null)
            {
                p = p.link;
            }
            p.link = new Node(value);
        }

        //add in recursion
        //need to convert header to public for I can pass parameter to method
        //or make mehtod call this and inside it decale node to header
        public void addR(object value, Node p)
        {
            if (p.link == null) { p.link = new Node(value); }
            else
            {
                addR(value, p.link);
            }
        }
        /*
        public void callAddr(object value)
        {
            Node p = header;
            addR(value, p);
        }
        */


        public void printNodes()
        {
            Node p = header;
            while (p.link != null)
            {
                p = p.link;
                Console.WriteLine(p.value);
            }
        }

        //print in recursion
        public void printR(Node p)
        {
            if (p.link == null) { Console.WriteLine(p.value); }
            else
            {
                Console.WriteLine(p.value);
                printR(p.link);
            }
        }


        //because I don't allow to modify node from main
        private Node findNode(object value)
        {
            Node p = header;
            while (p.link != null)
            {
                if (p.value.Equals(value)) { break; }
                p = p.link;
            }
            if (p.value.Equals(value)) { return p; }
            else { return null; }
        }


        private Node findPrevious(object value)
        {
            Node p = header;
            while (p.link != null)
            {
                if (p.link.value.Equals(value)) { break; }
                p = p.link;
            }
            if (p.link != null) { return p; }
            else { return null; }
        
        }

        public bool contain(object value)
        {
            if (findNode(value) != null) return true;
            else return false;
        }

        public int count()
        {
            int count = 0;
            Node p = header;
            while (p.link != null)//if you want to count header the condition becomes if(p!=nuul)
            {
                //we don't count the header
                p = p.link;
                ++count;
            }
            return count;
        }

        //count in recursion
        public int countR(Node p,int count=0)
        {
            if (p.link == null) { return count; }
            else
            {
                return countR(p.link,++count);
            }
        }

        public object Header
        {
            //header Node is define in this class
            get { return header.value;  }
            set { header.value = value; }
        }

        public void replace(object oldValue, object newValue)
        {
            Node current = findNode(oldValue);
            if (current != null)
            {
                current.value = newValue;
            }
        }

        public void insert(object val1,object newValue)
        {
            Node newNode = new Node(newValue);
            //where I want to add Node
            Node prev = findNode(val1);
            if (prev == null) { addNode(newValue); }
            else
            {
                //newNode isert between prevNode and nextNode
                Node nextNode = prev.link;
                prev.link = newNode;
                newNode.link = nextNode;

            }
        }

        public void remove(object targetValue)
        {
            Node prevNode = findPrevious(targetValue);
            if (prevNode == null) return;
            else
            {
                Node targetNode = prevNode.link;
                prevNode.link = targetNode.link;
                targetNode.link = null;
            }
        }

        //get value of node with specific index
        public object ElementAt(int index)
        {
            object value=null;
            int count = 0;
            Node p = header;
            while (p.link != null)
            {
                p = p.link;
                if (index == count) { value=p.value; break; }
                ++count; 
            }
            return value;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            AlinkedList ls = new AlinkedList();
            ls.Header = "Header";

            ls.addNode(5);
            ls.addNode(6);
            ls.addNode(9);

            //ls.insert(6, 8);
            //Console.WriteLine(ls.ElementAt(2));
            //Console.WriteLine("****************");
            ls.printNodes();
            Console.WriteLine("****************");

            int sum = 0;
            for (int i = 0; i < ls.count(); i++)
            {
                sum += (int)(ls.ElementAt(i));
            }
            Console.WriteLine("sum = " + sum);
            //ls.replace(9, "nine");
            //ls.printNodes();
            //Console.WriteLine("****************");
            //ls.remove(8);
            //ls.printNodes();
            //Console.WriteLine("****************");
            //Console.WriteLine(ls.Header);
            //Console.WriteLine("****************");
            //Console.WriteLine(ls.contain(6));
            //Console.WriteLine(ls.count());
            Console.ReadKey();

        }
    }
}
