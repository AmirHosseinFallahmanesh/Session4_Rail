using System;
using System.Collections.Generic;

namespace Part5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1)Add Name");
                Console.WriteLine("2)Edit Name");
                Console.WriteLine("3)Delete Name");
                Console.WriteLine("4)Search Name");
                Console.WriteLine("5)Print Names");
                Console.WriteLine("6)Exit");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Enter Name");
                        string name = Console.ReadLine();
                        names.Add(name);
                        break;

                    case "2":
                        {
                            Console.Clear();
                            Console.WriteLine("Enter Name");
                            string search = Console.ReadLine();
                            for (int i = 0; i < names.Count; i++)
                            {
                                if (names[i]==search)
                                {
                                    Console.WriteLine("Enter New Name");
                                    names[i] = Console.ReadLine();
                                }
                            }
                        }
                        break;

                    case "3":
                        {
                            Console.Clear();
                            Console.WriteLine("Enter Name");
                            string search = Console.ReadLine();
                            int index = 0;
                            for (int i = 0; i < names.Count; i++)
                            {

                                if (names[i] == search)
                                {
                                    index = i;
                                }
                            }
                            names.RemoveAt(index);

                        }
                        break;

                    case "4":
                        {
                            Console.Clear();
                            Console.WriteLine("Enter Search");
                            string search = Console.ReadLine();
                            for (int i = 0; i < names.Count; i++)
                            {
                                if (names[i].StartsWith(search))
                                {
                                    Console.WriteLine(names[i]);
                                }
                            }
                            Console.ReadKey();
                        }
                        break;

                    case "5":
                        Console.Clear();
                        Console.WriteLine("Names List");
                        for (int i = 0; i < names.Count; i++)
                        {
                            Console.WriteLine(names[i]);
                        }
                        Console.ReadKey();
                        break;

                    case "6":
                        break;
                    default:
                        Console.WriteLine("Try Agian");
                        Console.ReadKey();
                        break;
                }



            }
        }
    }
}
