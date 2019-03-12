using System;

namespace MenuProject
{
    class Program
    {
        public static class Globals //Global variables
        {
            public static String Name = "";
            public static Random rng = new Random(); // Random number is generated 
        }

        public static void Intro() //Initial Program for introduction
        {
            Console.WriteLine("Please Enter your name: \n"); //Prompts for a name
        }

        public static double add(double i, double j)
        {
            return i + j;
        }

        public static double subtract(double i, double j)
        {

            return i - j;
        }

        public static double divide(double i, double j)
        {
            return i / j;
        }

        public static double multiply(double i, double j)
        {
            return i * j;
        }

        public static void Calculator()
        {
            double i, j, result=0;
            int op,loop = 1;
            Console.WriteLine("Please Enter the First input: ");
            i = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter the Second input: ");
            j = Convert.ToDouble(Console.ReadLine());
            while (loop == 1)
            {
                Console.WriteLine("Select an operator:\n 1.add\n 2.subtract\n 3.divide\n 4.multiply\n\n" + i + " __ " + j);
                op = Convert.ToInt32(Console.ReadLine());
                if (op == 1)
                {
                    result = add(i, j);
                    loop = 0;
                }

                else if (op == 2)
                {
                    result = subtract(i, j);
                    loop = 0;
                }

                else if (op == 3)
                {
                    result = divide(i, j);
                    loop = 0;
                }

                else if (op == 4)
                {
                    result = multiply(i, j);
                    loop = 0;
                }

                else
                    Console.WriteLine("Incorrect operator please use an integer to choose an operator.\n");
            }
            Console.WriteLine("The Answer is: "+result);
        }

        public static void FlipACoin() //Flips a Coin
        {
            Boolean run = true;
            String again = "no";
            while (run == true) //Loop for a coin flipper
            {
               
                int flip = Globals.rng.Next(1, 3); // 1 or 2 is flipped, 1= Head, 2= Tails
                String coin;
                if (flip == 1)
                {
                    coin = "Head";
                }
                else
                    coin = "Tails";

                Console.WriteLine("The coin is flipped... " + coin + "!\n"); //Result

                Console.WriteLine("Would you like to flip again? y/n \n"); //Prompt to Flip again
                again = Console.ReadLine();
                if (again == "y" || again == "yes") // Prompts user for a re-flip
                {
                    run = true;
                }
                else 
                    run = false;
 
            }
            Exit();
            Menu();
        }

        public static void DecisionMaker() //Multi option decision maker
        {
            int amount,i,j;
            Console.WriteLine("Please Enter the amount of decisions to be made: ");
            amount = Convert.ToInt32(Console.ReadLine()); //Convert String read to integer
            String[] decisions = new String[amount];    //Array of strings for decisions

            for (i = 0; i < amount; i++)    //For loop to read decisions
            {
                Console.WriteLine("\nEnter a decision: ");
                decisions[i] = Console.ReadLine(); 
            }
            Console.WriteLine("\n************************************************************\n");
            Console.WriteLine("Creating a decision... \n");
            int decide = Globals.rng.Next(0,i); //Creates a Decision with random generator
            Console.WriteLine(decisions[decide]+"!!!\n");
            Exit();
            Menu();
        }

        public static void Exit() //Exit Program Menu
        {
            Console.WriteLine("Exiting Program...\n");
        }

        public static void Menu() //Menu for all program Projects
        {
            int caseSwitch;
            Console.WriteLine("Please Use a Number to Select One of the Following Options:\n");
            Console.WriteLine("**********************************************************\n");
            Console.WriteLine("" +
                "1. Terminal Calculator\n" +
                "2. Flip a Coin\n" +
                "3. Decision Maker\n");
            caseSwitch = Convert.ToInt32(Console.ReadLine()); //Converts ReadLine String to an Integer
            switch (caseSwitch)
            {
                case 1:
                    Calculator();
                    break;
                case 2:
                    FlipACoin();
                    break;
                case 3:
                    DecisionMaker();
                    break;
                case 0:
                    Exit();
                    break;
                default:
                    Console.WriteLine("Invalid entry. Try again or exit the program with 0.\n");
                    break;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User!\n");
            Intro();
            Menu();
 
        }
    }
}
