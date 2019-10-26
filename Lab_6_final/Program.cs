using System;

namespace Lab_6_final
{
    class Program
    {
        static int i = 1;

        // initiat static variable to be accessed by the class

        static int dice1, dice2;
        static Random Random;
        
        //  Main Method
        public static void Main()
        {
            Random = new Random();
            Console.WriteLine("Welcome to the Grand Circus Casino! Roll the dice? (y/n):");
            char Repeat = char.Parse(Console.ReadLine());
            Verify(Repeat);

            if (Repeat == 'Y' || Repeat == 'y')
            {

                Console.WriteLine("How many sides should each die have?  ");
                int sides = int.Parse(Console.ReadLine());

                while (Repeat == 'Y' || Repeat == 'y')
                {

                    //  Create new Random object.

                    GeneratNum(sides);

                    // print the roll 

                    Console.WriteLine("Roll " + i + " :");
                    Console.WriteLine(dice1);
                    Console.WriteLine(dice2);
                    if (dice1 <=dice2 && dice1 != dice2)
                    {
                        Console.WriteLine("craps");
                    }
                    if (dice1 == dice2)
                    {
                        Console.WriteLine("snake eyes");
                    }
                    if (dice1 >= dice2 && dice1 != dice2)
                    {
                        Console.WriteLine("box cars");
                    }
                    Console.WriteLine("Roll again? (y/n): ");
                    Repeat = char.Parse(Console.ReadLine());
                    Verify(Repeat);
                    i++;

                }

            }

            Console.WriteLine("Good Bay");

        }
        // Get the Random Number 
        public static void GeneratNum(int maxSides)
        {
            dice1 = Random.Next(1, maxSides);
            dice2 = Random.Next(1, maxSides);

        }
        // Verify ethod to verify if the input is right or wrong
        public static void Verify(char respond)
        {

            if (respond != 'Y' && respond != 'y' && respond != 'n' && respond != 'N')
            {
                Console.WriteLine("Please Type a valide input (y/n)");
            }

        }

    }

}

