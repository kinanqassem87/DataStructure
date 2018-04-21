using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class CArrayList <t>
    {
        t[] list;


        public CArrayList()
        {
            list = new t[0];
        }


        public int Add(t item)
        {
            t[] newList = new t[list.Length + 1];
            for (int i = 0; i < list.Length; i++)
            {
                newList[i] = list[i];
            }
            newList[newList.Length - 1] = item;
            list = newList;
            return list.Length - 1;
        }

        public void Insert(int index, t item)
        {
            t[] newList = new t[list.Length + 1];
            newList[index] = item;
            for (int i = 0; i < list.Length; i++)
            {
                if (newList[i] == null)
                {
                    newList[i] = list[i];
                }
                else
                {
                    newList[i + 1] = list[i];
                }
            }
            list = newList;

        }

        public void Delete(int index)
        {
            int n = 0;
            t[] newList = new t[list.Length - 1];
            for (int i = 0; i < list.Length; i++)
            {
                if (i != index)
                {
                    newList[n] = list[i];
                    n++;
                }
            }
            list = newList;
        }

        public t this[int index]
        {
            get { return list[index]; }
            set { list[index] = value; }
        }
        //or this
        /*
        public t getItem(int index)
        {
            return list[index];
        }
        public void changeItem(int index, t newItem)
        {
            list[index] = newItem;

        }
        */





        public int indexOF(t item)
        {
            for (int i = 0; i < list.Length; i++)
                if (list[i].ToString().Equals(item.ToString()))
                    return i;
            return -1;
        }



        public int Length
        {
            get { return list.Length; }
        }
    }
    
    class Program
    {

        static void swap<t>(ref t x, ref t y)
        {
            t temp;
            temp = x;
            x = y;
            y = temp;
        }

        static void Main(string[] args)
        {
            /*
            //generic for object
            CArrayList<int> list = new CArrayList<int>();
            list.Add(2);
            list.Add(3);
            int sum = 0;
            //cann't use foreach becuase this isn't built in arraylist 
            for (int i = 0; i < list.Length; i++)
            {
                sum += list[i];
            }
            Console.Write(sum);*/

            //generic for method
            int a = 10;
            int b = 15;
            Console.WriteLine("a= " + a + ", b= " + b);
            swap<int>(ref a,ref b);
            Console.WriteLine("a= "+a+", b= "+b);

            Console.ReadKey();
        }
    }
}
