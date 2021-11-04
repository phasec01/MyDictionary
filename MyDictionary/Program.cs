using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(21,"Oguz");
            myDictionary.Print();


        }


        class MyDictionary<TKey, TValue>
        {
            TKey[] _key;
            TKey[] _tempKey;

            TValue[] _value;
            TValue[] _tempValue;
            public MyDictionary()
            {
                _key = new TKey[0];
                _value = new TValue[0];

            }

            public void Add(TKey itemKey, TValue itemValue)
            {
                _tempKey = _key;
                _tempValue = _value;
                _key = new TKey[_tempKey.Length + 1];
                _value = new TValue[_tempValue.Length + 1];


                for (int i = 0; i < _key.Length - 1; i++)
                {
                    _key[i] = _tempKey[i];
                    _value[i] = _tempValue[i];
                }

                _key[_key.Length - 1] = itemKey;
                _value[_value.Length - 1] = itemValue;
                Console.WriteLine("Value : " + _value[_value.Length - 1] + "  Key : " + _key[_key.Length - 1]);

            }

            public void Print()
            {
                for (int i = 0; i < _key.Length; i++)
                {
                    
                    Console.WriteLine(_key[i] + " " + _value[i]);
                }
            }






        }

        
    }
}
