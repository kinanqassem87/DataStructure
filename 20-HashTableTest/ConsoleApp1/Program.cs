using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    class HashNode
    {
        public object key;
        public object value;
        //this link is represent object of Node so we use link with type Node
        //this is object of Node
        public HashNode link;
        public HashNode(object key,object value)
        {
            this.key = key;
            this.value = value;
        }
        public HashNode() { }

        public object getkey() { return key; }
        public object getvalue() { return value; }
    }

    class IHashTable
    {
        int size;
        HashNode[] arrayHash;

        public IHashTable(int size)
        {
            this.size = size;
            arrayHash = new HashNode[this.size];
            for (int i = 0; i < arrayHash.Length; i++)
            {
                arrayHash[i] = new HashNode("header", "header");
            }
        }

        public int getHashKey(object key)
        {
            return ((int)key) % size;
            
        }
        

        public void put(object key, object value)
        {
            int index = getHashKey(key);
            HashNode p = arrayHash[index];
            HashNode newitem = new HashNode(key, value);

            while (p.link != null)
            {
                p = p.link;
               // Console.WriteLine("*");
            }
            p.link = newitem;
           // Console.WriteLine(p.link.value);
        }


        public HashNode get(object key)
        {
           
            int index = getHashKey(key);
            HashNode p = arrayHash[index];

            while (p.link != null)
            {
                //Console.WriteLine("p not null");
                if (p.key.Equals(key)) {  break; }
                p = p.link;
            }
            if (p.key.Equals(key)) { return p; }

            else { return null; }

        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            
            IHashTable ht = new IHashTable(5);
            ht.put(2, "kinan");
            ht.put(7, "kinan2");
            ht.put(1, "zaino");
            
            Console.WriteLine(ht.get(7).value);
            


            //hashTable built in
            /*
            Hashtable hh = new Hashtable(10);
            hh.Add(1, "kinan");
            hh.Add(2, "zaino");
            hh.Add(3, "shaza");

            Console.WriteLine( hh.Values);

            */

            Console.ReadKey();
        }
    }
}
