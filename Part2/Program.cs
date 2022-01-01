using System;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[4];
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;

            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[2]);

            Console.WriteLine("The Size of Array "+numbers.Length);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("numbers "+i+" => "+numbers[i]);
            }
            Console.ReadKey();
        }
    }
}
