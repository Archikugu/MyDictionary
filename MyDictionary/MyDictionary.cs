using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class MyDictionary<Tkey, Tvalue>
    {
        KeyValuePair<Tkey, Tvalue>[] items;

        public MyDictionary()
        {
            items = new KeyValuePair<Tkey, Tvalue>[0];

        } //Default Constructor

        public void Add(Tkey key, Tvalue value)
        {
            KeyValuePair<Tkey, Tvalue>[] tempArray = items;  // Geçici dizimizi oluşturduk
            items = new KeyValuePair<Tkey, Tvalue>[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];  //Geçici dizideki elemanları alıp asıl dizimize geri koyduk.
            }
            items[items.Length - 1] = new KeyValuePair<Tkey, Tvalue>(key, value);
        }

        public void ShowList()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }
        public int Count
        {
            get { return items.Length; }
        }
        
    }
}