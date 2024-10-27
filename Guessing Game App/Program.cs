namespace Guessing_Game_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Guessing Game!");
            Random random = new Random();
            String choice;
           // int answer = random.Next(1, 101);//1 higher than 100 because the upper band is exclusive
            do
            {
                Console.WriteLine("I'm thinking of a number from 1 to 100." +
                    "\nTry to guess it.");

                //Console.Write("Enter your number: ");
                //int entry = int.Parse(Console.ReadLine());

                int tries = 0;
                bool correctGuess = false;
                //int difference = Math.Abs(answer - entry);
                int answer = random.Next(1, 101);//1 higher than 100 because the upper band is exclusive
                while (!correctGuess)
                {
                    Console.Write("Enter your number: ");
                    //int entry = int.Parse(Console.ReadLine());

                    if (int.TryParse(Console.ReadLine(), out int entry))
                    {
                        tries++;
                        int difference = Math.Abs(answer - entry);
                        if (entry == answer)
                        {
                            if (tries <= 3)
                            {
                                Console.WriteLine("Fantastic! You got it right!");
                                Console.WriteLine($"You got it right in {tries} guesses!\n");
                            }
                            else if (tries >3 && tries <= 7)
                            {
                                Console.WriteLine("Not bad!");
                                Console.WriteLine($"You got it right in {tries} guesses!\n");
                            }
                            else if (tries > 7 && tries <= 10)
                            {
                                Console.WriteLine("You might be a numbskull.");
                                Console.WriteLine($"You got it right in {tries} guesses!\n");
                            }
                            else
                            {
                                Console.WriteLine("Yeah, definitely a numbskull.");
                                Console.WriteLine($"You got it right in {tries} guesses!\n");
                            }
                            correctGuess = true;
                        }
                        else if (entry > answer)
                        {
                            if (difference > 10)
                            {
                                Console.WriteLine("You are way too high!");
                             //   tries++;
                            }
                            else
                            {
                                Console.WriteLine("Too high");
                               // tries++;
                            }
                        }
                        else if (entry < answer)
                        {
                            if (difference > 10)
                            {
                                Console.WriteLine("You are way too low!");
                               // tries++;
                            }
                            else
                            {
                                Console.WriteLine("Too low");
                               // tries++;
                            }
                        }
                        else if (entry < 1 || entry > 100)
                        {
                            Console.WriteLine("I literally told you to enter something between 1 and 100.\n");
                            //tries++;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid number! >:(\n");
                            //tries++;
                        }
                    }
                }
                    Console.Write("Would you like to go again? (y/n): ");
                    choice = Console.ReadLine().ToLower();
                } while (choice == "y") ;
                Console.WriteLine("\nGoodbye, thanks for playing!");
            }
    }
    }

