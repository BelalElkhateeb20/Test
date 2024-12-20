using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace ConsoleApp5.Prop_indexer
{
    public struct Phonebook
    {
        private long[] numbers;
        private string[] names;
        private int size;
        public Phonebook( int Size)
        {
            this.size = Size;
            numbers = new long[Size];
            names = new string[Size];

        }
        public int _size { get { return size; } }
        public void entryRange (int index,string name,long number)
        {
            if((index>=0)&&(index<=size))
            {
                numbers[index] = number;
                names[index] = name;
            }
        }
        public long GetNumber(string _name)
        {
            for (int i = 0; i < names?.Length; i++)
            {
                if (names[i] == _name)
                    return numbers[i];
            }
            return -1;
        }
        public long this[string _name]
        {
            get
            {
                for (int i = 0; i < names?.Length; i++)
                {
                    if (names[i] == _name)
                        return numbers[i];
                }
                return -1;
            }
            set
            {
                for (int i = 0; i < names?.Length; i++)
                {
                    if (names[i] == _name)
                        numbers[i] = value;
                }
            }
        }
        public long this[long index, string _name]
        {
            set
            {
                if ((index >= 0) && (index <= size))
                {
                    numbers[index] = value;
                    names[index] = _name;
                }
            }
        }
    }
}
