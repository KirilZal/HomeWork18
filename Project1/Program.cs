using ClassLibrary1;
using System;
using System.Runtime.InteropServices.Marshalling;
using System.Text.Unicode;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<string, int> myDIC = new MyDictionary<string, int>();
            myDIC.Add("hundred", 100);
            myDIC.Add("two hundred", 200);
            myDIC.Add("three hundred", 300);
            foreach (var smal in myDIC)
            {
                Console.WriteLine($"key {smal.Key}+ value  {smal.Value}");
            }
        }
    }
}