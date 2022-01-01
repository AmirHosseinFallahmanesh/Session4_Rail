using System;
using System.Collections.Generic;

namespace Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("amir");
            names.Add("reza");
            names.Add("sina");
            names.Insert(2, "sima");
            names.RemoveAt(2);
            names.Remove("sina");
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }

        }
    }
}
