using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class DictionaryProperty<T,Y>
    {
        public DictionaryProperty(T key, Y value)
        {
            Key = key;
            Value = value;
        }
    
        public T Key { get; set; }
        public Y Value { get; set; }
    }
}
