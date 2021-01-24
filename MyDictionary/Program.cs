
using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enlish to French dictionary");
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.Add("One", "Un");
            myDictionary.Add("Two", "Deux");
            myDictionary.Add("Three", "Trois");
            myDictionary.Add("Four", "Uatre");
            myDictionary.Add("Five", "Cinq");

            myDictionary.Read();

        }
    }
}