using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CArrayList
    {
        object[] list;


        public CArrayList()
        {
            list = new object[0];
        }


        public int Add(object item)
        {
            object[] newList = new object[list.Length + 1];
            for (int i = 0; i < list.Length; i++)
            {
                newList[i] = list[i];
            }
            newList[newList.Length-1] = item;
            list = newList;
            return list.Length - 1;
        }

        public void Insert(int index, object item)
        {
            object[] newList= new object[list.Length + 1];
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
            object[] newList = new object[list.Length - 1];
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
        
        public object this[int index]
        {
            get { return list[index]; }
            set { list[index] = value; }
        }
        //or this
        /*
        public object getItem(int index)
        {
            return list[index];
        }
        public void changeItem(int index, object newItem)
        {
            list[index] = newItem;

        }
        */





        public int indexOF(object item)
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
        static void Main(string[] args)
        {
            
            CArrayList ca = new CArrayList();
            ca.Add("kinan");
            ca.Add("qassem");
            ca.Add("shaza");
            ca.Add("zain");
            /*
            ca.Insert(1, "Rayan");

            ca.Delete(2);
           // string x = ca.getItem(1).ToString();
            for (int i = 0; i < ca.Length; i++)
            {
                Console.WriteLine(ca.getItem(i));
            }*/

            //  Console.WriteLine(x);


            Console.WriteLine(ca[0]);
            ca[1] = "Ahmad";
            Console.WriteLine(ca[1]);


            Console.ReadKey();
            
        }
    }
}
