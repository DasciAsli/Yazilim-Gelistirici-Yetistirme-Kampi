using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class DictionaryManager<T,Y>
    {
        DictionaryProperty<T, Y>[] dictionaries;
        public DictionaryManager()
        {
            dictionaries = new DictionaryProperty<T, Y>[0];
        }
        public void Add(T item1,Y item2)
        {
            DictionaryProperty<T, Y>[] tempDictionaries = dictionaries;
            dictionaries = new DictionaryProperty<T, Y>[tempDictionaries.Length +1];
            for (int i = 0; i < tempDictionaries.Length; i++)
            {
                dictionaries[i] = tempDictionaries[i];
            }
            DictionaryProperty<T, Y> newdictionary = new DictionaryProperty<T, Y>(item1,item2);
            dictionaries[dictionaries.Length - 1] = newdictionary;

        }
        public void Listele()
        {
            for (int i = 0; i < dictionaries.Length; i++)
            {
                Console.WriteLine(dictionaries[i].Key + " : " + dictionaries[i].Value);
            }
        }
    }
}
