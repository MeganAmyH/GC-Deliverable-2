using System;

namespace Deliverable_2
{
    class Program
    {
        private static string userInput;

        static void Main(string[] args)
        {
            int c1 = 1;
            int c2 = 1;
            int c3 = 1;
            
            Console.WriteLine("Hello! Welcome to ChatBot2021.");

            while ((userInput != "hello") || (userInput != "sup") || (userInput != "hello there"))
            {
                Console.WriteLine("What would you like to say? Hello/Bye/Sup/Hello there ");

                string userInput = Console.ReadLine().ToLower();


                if (userInput == "hello" && c1 == 1)
                {
                    Console.WriteLine("Hi, good to see you!");
                    c1++;
                }
                else if (userInput == "sup" && c2 == 1)
                {
                    Console.WriteLine("I am good.");
                    c2++;
                }
                else if (userInput == "hello there" && c3 == 1)
                {
                    Console.WriteLine("General Kenobi");
                    c3++;
                }
                else if (userInput == "bye")
                {
                    Console.WriteLine("Great to chat with you. Goodbye!");
                    Environment.Exit(0);
                }
                else if ((userInput != "hello") && (userInput != "sup") && (userInput != "hello there"))
                {
                    Console.WriteLine("That's not one of the choices.");
                }


                else if ((c1 > 1) || (c2 > 1) || (c3 > 1))
                {
                    Console.WriteLine("I'm sorry, but you've already said that");

                }

            }           
        }
    }
}
