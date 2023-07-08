using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    public class DictionaryDemo
    {
        public void Check()
        {
            Dictionary<string, string> keyValueobject = new Dictionary<string, string>();
            keyValueobject.Add("1", "HEMANT");
            keyValueobject.Add("2", "Saini");
            keyValueobject.Add("3", "HEM");
            Console.WriteLine(keyValueobject["3"]);
            keyValueobject["2"]= "SAINI";
            Console.WriteLine(keyValueobject["2"]);
            keyValueobject.Remove("2");

            foreach (KeyValuePair<string, string> item in keyValueobject)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }
            keyValueobject.Clear();
            Console.WriteLine("ALL ELEMENT IS DELETED");
            for (int i=0; i< keyValueobject.Count; i++)
            {
                var item = keyValueobject.ElementAt(i);
                Console.WriteLine(item.Value);
            }


        }
    }
}
