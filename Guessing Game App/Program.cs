namespace Guessing_Game_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Guessing Game!");
            Random random = new Random();
            String choice;
            int answer = random.Next(1, 101);//1 higher than 100 because the upper band is exclusive
            do 
            {
                Console.WriteLine("I'm thinking of a number from 1 to 100." +
                    "\nTry to guess it.");
                Console.Write("Enter your number: ");
                int entry = int.Parse(Console.ReadLine());
                
                int tries = 0;
                int difference = Math.Abs(answer - entry);
                if (entry == answer)
                {
                    Console.WriteLine("Fantastic! You got it right!");
                    Console.WriteLine($"You got it right in {tries} guesses!\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if(entry > answer)
                {
                    if (difference > 10)
                    {
                        Console.WriteLine("You are way too high!");
                        tries++;
                    }
                    else
                    {
                        Console.WriteLine("Too high");
                        tries++;
                    }
                }
                else if (entry < answer)
                {
                    if (difference > 10)
                    {
                        Console.WriteLine("You are way too low!");
                        tries++;
                    }
                    else
                    {
                        Console.WriteLine("Too low");
                        tries++;
                    }
                }
                else if (entry < 1 || entry > 100)
                {
                    Console.WriteLine("I literally told you to enter something between 1 and 100.\n");
                    tries++;
                }
                else
                {
                    Console.WriteLine("You got it wrong! >:(\n");
                    tries++;
                }
                Console.Write("Would you like to go again? (y/n): ");
                choice = Console.ReadLine().ToLower();
            }while(choice == "y");
        }
    }
}
