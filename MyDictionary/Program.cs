using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> members = new MyDictionary<int, string>();

            members.Add(10, "emin");
            members.Add(20, "muhammed");

            
        }
    }
}
