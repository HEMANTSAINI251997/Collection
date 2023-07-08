using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    public class ArrayListDemo
    {
        ArrayList arraylist = new ArrayList();
        public void Myarray()
        {
            arraylist.Add(1);
            arraylist.Add("HEMANT");
            arraylist.Add("  ");
            arraylist.Insert(0, 20);
            arraylist.Insert(2, 'a');
            arraylist.Remove("HEMANT");
            arraylist.RemoveAt(1);
            Console.WriteLine(arraylist.Count);
            foreach (var item in arraylist)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine("..........For Loop.........");
            //for (int i=0; i<arraylist.Count; i++)
            //{
            //    Console.WriteLine(arraylist[i]);
            //}
        }
    }
}
