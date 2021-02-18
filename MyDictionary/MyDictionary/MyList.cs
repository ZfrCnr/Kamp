using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyList<T>
    {
        T[] Item, tempArray;
        public MyList()
        {
            Item = new T[0];
        }
        public void Add(T item)
        {
            tempArray = Item;
            Item = new T[Item.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                Item[i] = tempArray[i];
            }
            Item[Item.Length - 1] = item;

        }

        public int Count
        {
            get { return Item.Length; }
        }
        public T[] Items
        {
            get { return Item; }
        }

    }
}
