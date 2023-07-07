using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    public class ListDemo
    {
        List<int> list = new List<int>();
        public void Adding()
        {
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count of LIST =" + list.Count);
            Console.WriteLine("List Capacity =" + list.Capacity);
            list.Add(21);
            list.Add(30);
            Console.WriteLine("List Capacity =" + list.Capacity);
            Console.WriteLine("Find element =" + list.Contains(3));
            Console.WriteLine("Removed element =" + list.Remove(3));
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("************");

            Console.WriteLine("Remove Element by Index position");
            list.RemoveAt(4);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("************");
            Console.WriteLine("Sorting the List");


            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("************");
            Console.WriteLine("Reverse the List");

            list.Reverse();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("************");


            list.Clear();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("************");


        }
    }
}
