using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    public class MyEditor<U, T>
    {
        Dictionary<U, List<T>> dictionary;

        public MyEditor()
        {
            dictionary = new Dictionary<U, List<T>>();
        }

        public void Add(U key, T value)
        {
            List<T> list;
            if (this.dictionary.TryGetValue(key, out list))
            {
                list.Add(value);
            }
            else
            {
                list = new List<T>();
                list.Add(value);
                this.dictionary[key] = list;
            }
        }

        public Dictionary<U, List<T>> Dictionary
        {
            get { return dictionary; }
        }
    }

}