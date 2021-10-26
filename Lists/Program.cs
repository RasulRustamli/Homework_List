using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<string> list = new MyList<string>();
            list.Add("Gun");
            list.Add("Sa");
            list.Add("E");
            list.Add("E");
            List<string> list3 = new List<string>();
            list3.Add("dasdsadas");
            list3.Add("b");
            list3.Add("c");
            list3.Add("d");
            list3.Add("d");

            list3.IndexOf("n");
            list.Clear();
            Console.WriteLine(list.Count);
            Console.WriteLine(list[4]);

        }
    }
}
