using System;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = String.Empty;
            bool isInputValid = false;
            int num = 0;
            bool shouldContinue = false;

            for (int i = 0; i < People.GetLength(0); i++)
            {
                for (int j = 0; j < People.GetLength(1); j++)
                {
                    Console.WriteLine($"Name: {People[i, 0]}, hometown: {People[i, 1]}, favoreite food: {People[i, 2]}");
                }
            }

            Console.WriteLine();
            Console.WriteLine("\tName\tTown\tFood");

            for (int i = 0; i < People.GetLength(0); i++)
            {
                for (int j = 0; j < People.GetLength(1); j++)
                {
                    Console.Write($"\t{People[i,j]}");
                }
                Console.WriteLine();
            }

            //Console.WriteLine("Enter a number between 1-2");

            //do
            //{
            //    input = Console.ReadLine();
            //    num = int.Parse(input);
            //    if (num < 0 || num > People.GetLength(0))
            //    {
            //        Console.WriteLine("That person does not exist.  Please try again (1-2)");
            //    }
            //    else
            //    {
            //        isInputValid = true;
            //        Console.WriteLine("Student {0} is {1}.", num, People[num - 1, 0]);
            //    }
            //} while (!isInputValid);

            //do
            //{
            //    shouldContinue = false;

            //    Console.WriteLine("What would you like to know about {0}?", People[num - 1, 0]);

            //    do
            //    {
            //        input = Console.ReadLine();
            //        if (!input.Equals("hometown", StringComparison.InvariantCultureIgnoreCase) && !input.Equals("favorite food", StringComparison.InvariantCultureIgnoreCase))
            //        {
            //            isInputValid = false;
            //            Console.WriteLine("That data does not exist.  Please try again. (enter \"hometown\" or \"favorite food\")");
            //            input = Console.ReadLine();
            //        }
            //        else
            //        {
            //            isInputValid = true;
            //            if (input.Equals("favorite food", StringComparison.InvariantCultureIgnoreCase))
            //            {
            //                Console.WriteLine("{0}'s favorite food is {1}", People[num - 1, 0], People[num - 1, 2]);
            //            }
            //            else
            //            {
            //                Console.WriteLine("{0} is from {1}.", People[num - 1, 0], People[num - 1, 1]);
            //            }
            //        }
            //    } while (isInputValid);

            //    Console.WriteLine("Would you like to know more?");

            //    input = Console.ReadLine();

            //    if (input.Equals("y", StringComparison.InvariantCultureIgnoreCase))
            //    {
            //        shouldContinue = true;
            //    }

            //} while (shouldContinue);

            Console.ReadKey();
        }

        static string[,] People = new string[,]
        {
            {"Adriana", "New York", "French Toast"},
            {"Milton", "Atlanta", "Bisquits and Gravy" },
            {"Shark", "Mars", "Boogers" }
        };
    }
}
