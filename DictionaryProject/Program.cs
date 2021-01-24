using System;

namespace DictionaryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> myDictionary = new MyDictionary<int,string>();
            myDictionary.Add(123,"Melda");
            myDictionary.Add(456, "Serpil");

        }
    }
}
