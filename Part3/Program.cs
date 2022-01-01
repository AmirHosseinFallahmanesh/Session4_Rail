using System;

namespace Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] marks = new float[4];

            while (true)
            {
                Console.Clear();

                Console.WriteLine("1)Add Mark");
                Console.WriteLine("2)Get Average");
                Console.WriteLine("3)Report");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Clear();
                        for (int i = 0; i < marks.Length; i++)
                        {
                            Console.WriteLine("Enter Mark");
                            marks[i] = Convert.ToSingle(Console.ReadLine());
                        }

                        break;
                    case "2":
                        Console.Clear();
                        float total = 0;
                        for (int i = 0; i < marks.Length; i++)
                        {
                            total += marks[i];

                        }
                        float average = total / 4;
                        Console.WriteLine("The Average is " + average);
                        Console.ReadKey();

                        break;
                    case "3":
                        Console.WriteLine("Marks is =>");
                        int faildCount = 0;
                        for (int i = 0; i < marks.Length; i++)
                        {
                            if (marks[i]<10)
                            {
                                faildCount++;
                            }
                           Console.WriteLine($"Marks [{i}] = {marks[i]}");
                        }
                        Console.WriteLine("The Failed Count is : "+faildCount);
                        Console.WriteLine("The Total Count is : "+marks.Length);

                        Console.ReadKey();
                        break;
                    default:

                        break;
                }


            }

        }
    }
}
