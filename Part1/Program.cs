using System;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            int lowerBound = 0;
            int upperBound = 0;
            Console.WriteLine("Select Domain");
            Console.WriteLine("1)1-100");
            Console.WriteLine("2)1-1000");
            Console.WriteLine("3)1-10000");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    lowerBound = 1;
                    upperBound = 100;
                    break;

                case 2:
                    lowerBound = 1;
                    upperBound = 1000;
                    break;

                case 3:
                    lowerBound = 1;
                    upperBound = 10000;
                    break;
                default:

                    break;
            }

            int maxCount = 0;
            Console.WriteLine("Select Mode");
            Console.WriteLine("1)Easy"); //10
            Console.WriteLine("2)Normal"); //7
            Console.WriteLine("3)Hard"); //5
             input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    maxCount = 10;
                    break;

                case 2:
                    maxCount = 7;
                    break;

                case 3:
                    maxCount = 5;
                    break;
                default:
                    
                    break;
            }

            int value = randomGenerator.Next(lowerBound, upperBound);
            Console.Clear();
            int counter = 0;
            while (true)
            {
                if (counter>maxCount)
                {
                    Console.Clear();
                    Console.WriteLine("Game Over");
                    break;
                }
                Console.WriteLine("Guess Number");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess>value)
                {
                    Console.WriteLine("Enter Lower Number");
                }
                else if (guess<value)
                {
                    Console.WriteLine("Enter Higher Number");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You Win !!!!!");
                    break;
                }

                counter++;
            }


        }
    }
}
