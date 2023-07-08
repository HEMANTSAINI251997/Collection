using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1-List");
                Console.WriteLine("2-Array");
                Console.WriteLine("3-ArrayList");
                Console.WriteLine("4-Dictionary");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        ListDemo listdemo = new ListDemo();
                        listdemo.Adding();
                        break;
                    case 2:
                        ArrayDemo arrayDemo = new ArrayDemo();
                        arrayDemo.Add();
                        break;
                    case 3:
                        ArrayListDemo  arraylistdemo = new ArrayListDemo();
                        arraylistdemo.Myarray();
                        break;
                    case 4:
                        DictionaryDemo dictionaryDemo = new DictionaryDemo();
                        dictionaryDemo.Check();
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }

        }
    }
}
