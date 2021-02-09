using System;
using System.Collections;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyEditor<int, string> dictionary = new MyEditor<int, string>();
            dictionary.Add(1, "BB");
            dictionary.Add(3, "FF");
            dictionary.Add(1, "AA");
            dictionary.Add(2, "CC");
            dictionary.Add(2, "DD");

            foreach (var item in dictionary.Dictionary)
            {
                Console.Write("Key => " + item.Key + ", ");
                var count = 1;
                foreach (var value in item.Value)
                {
                    if (count < item.Value.Count)
                    {
                        Console.Write(value + ", ");
                    }
                    else
                    {
                        Console.WriteLine(value);
                    }
                    count++;
                }
            }
        }
    }
}
