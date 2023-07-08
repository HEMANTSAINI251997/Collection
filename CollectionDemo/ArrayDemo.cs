using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    public class ArrayDemo
    {
        public void Add()
        {
            int[] myArray = new int[10];
            string[] strings = new string[10];

            int[] obj = new int[] { 1, 2, 3 };
            int[] ints = { 1, 2, 3, 4, 5 };

            string[] string_one = new string[4] { "HEM", "SAINI", "HEMANT", "HELLO" };
            foreach (string val in string_one)
            {
                Console.WriteLine(val); 
            }
            Console.WriteLine(".........FOR LOOP.........");
            for (int i=0;i<string_one.Length; i++)
            {
                Console.WriteLine(string_one[i]);
            }
            Console.WriteLine(".......WHILE LOOP.........");
            int a = 0;
            while (a < string_one.Length)
            {
                Console.WriteLine(string_one[a]);
                a++;
            }
        }
    }
}
