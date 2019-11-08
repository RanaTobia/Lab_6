using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab9
{
    class Program
    {

        static bool res = true;
        static bool rep;
        static int input;
        static string valid;
        static char validchar;
        static List<string> names = new List<string>() { "john", "Jacob", "Ed" };
        static List<string> homeTown = new List<string>() { "Detroit", "Merrillville", "NY" };
        static List<string> favoriteFood = new List<string>() { "Hot Doges", "Pizza", "Salad" };
        static List<string> favoriteColor = new List<string>() { "red", "blue", " white" };
        static bool resToAddStudent = true;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our C# class.");
            Console.WriteLine(" Would you like to \"search\" our student or \"add\" a new student ?  Enter 1 for search or 2 to add");

            int answer = int.Parse(Console.ReadLine());


            // Adding a new student to our collection
            if (answer == 2)
            {
                while (resToAddStudent)
                {
                    while (true)
                    {
                        Console.WriteLine("enter the name of the student");
                        string name = Console.ReadLine();
                        if (name == null || name == " " || name == string.Empty)
                        {
                            Console.WriteLine("null value not allowed");
                        }
                        else
                        {
                            names.Add(name);
                            break;
                        }
                    }

                    while (true)
                    {
                        Console.WriteLine("enter the town of the student");
                        string town = Console.ReadLine();

                        if (town == null || town == " " || town == string.Empty)
                        {
                            Console.WriteLine("null value not allowed");
                        }
                        else
                        {
                            homeTown.Add(town);
                            break;
                        }
                    }
                    while (true)
                    {
                        Console.WriteLine("enter the food of the student");
                        string food = Console.ReadLine();

                        if (food == null || food == " " || food == string.Empty)
                        {
                            Console.WriteLine("null value not allowed");
                        }
                        else
                        {
                            favoriteFood.Add(food);
                            break;
                        }
                    }

                    while (true)
                    {

                        Console.WriteLine("enter the color of the student");
                        string color = Console.ReadLine();
                        if (color == null || color == " " || color == string.Empty)
                        {
                            Console.WriteLine("null value not allowed");
                        }
                        else
                        {
                            favoriteColor.Add(color);
                            break;
                        }
                    }
                    AddMoreStudent();

                }
                
                static bool AddMoreStudent()
                {
                    //Char res1;

                    Console.WriteLine("Do you want to continu ? y/n ");
                    Char res1 = char.Parse(Console.ReadLine());
                    // res1 = InvalidChar(validchar);
                    if (res1 == 'y' || res1 == 'Y')
                    {
                        return resToAddStudent = true;
                    }
                    else
                    {
                        return resToAddStudent = false;

                    }
                }

                Console.WriteLine("Do you want search existing student or exit the program");
                Console.WriteLine("Enter \"1\" to search existing student or\"2\" to exit the program");
                int input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    int i = 0;
                    foreach (object el in names)
                    {

                        Console.WriteLine($"{i}_{el}") ;
                        i ++;
                    }
                    Console.WriteLine("Which student do you to know about");
                }
                else
                {
                    Console.WriteLine("Good Bye");
                    res = false;
                }
            }
            // Searching the student in the collection 
            else if (answer == 1)
                res = true;
            while (res)  // continue as long as the user  want to continu getting another student
            {

                try
                {
                    int count = names.Count();
                    Console.WriteLine($"Enter a number between 0 and {count-1}");
                    input = int.Parse(Console.ReadLine());
                    if (input > count)
                    {
                        Console.WriteLine("That student does not exist.Please try again");

                    }

                    else if (input <= count)
                    {
                        Console.WriteLine($"Student {input} is {names[input]} . What would you like to know about {names[input]}?  “hometown” ; “favorite food” or “color” ");
                        bool res2 = true;  // for while loop

                        while (res2 == true)  // continue if the user want to know more about the user
                        {
                            string option = Console.ReadLine();
                            if (option == "hometown" || option == "Hometown" || option == "HOMETOWN")
                            {
                                Console.WriteLine($"{names[input]} is from {homeTown[input]} Would you like to know more? (enter “yes” or “no):");
                                rep = Validation2();
                                if (rep != true)
                                {
                                    break;
                                }
                                else
                                {
                                    GetFavoriteFood(favoriteFood[input]);
                                    Console.WriteLine("and");
                                    GetColor(favoriteColor[input]);
                                }

                                res2 = false;
                            }
                            else if (option == "favorite food")
                            {
                                GetFavoriteFood(favoriteFood[input]);
                                Console.WriteLine(" Would you like to know more ? (enter “yes” or “no”):");
                                rep = Validation2();
                                if (rep != true)
                                {
                                    if (rep == false)
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    GetHomeTown(homeTown[input]);
                                    Console.WriteLine("and");
                                    GetColor(favoriteColor[input]);
                                }
                                res2 = false;
                            }
                            else if (option == "color" || option == "Color"|| option == "COLOR")
                            {
                                GetColor(favoriteColor[input]);
                                Console.WriteLine(" Would you like to know more ? (enter “yes” or “no”):");
                                rep = Validation2();
                                if (rep != true)
                                {
                                    if (rep == false)
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    GetHomeTown(homeTown[input]);
                                    Console.WriteLine("and");
                                    GetFavoriteFood(favoriteFood[input]);
                                }
                                res2 = false;
                            }
                            else
                            {
                                Console.WriteLine("That data does not exist.Please try again . (enter or “hometown” or “favorite food”):");
                                res2 = true;
                            }

                        }   // end the while loop

                    }   // end the while loop
                    validation();
                }

                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("index out of randge ex");
                }
                catch (FormatException)
                {
                    Console.WriteLine("there is some error. please try again.");

                }

            }

            // validation method to check if the user want to find another student information

            static bool validation()
            {
                Char res1;

                // Console.WriteLine("Do you want to continu ? y/n ");
                // Char res1 = char.Parse(Console.ReadLine());
                res1 = InvalidChar(validchar);
                if (res1 == 'y' || res1 == 'Y')
                {
                    return res = true;
                }
                else
                {
                    Console.WriteLine("Thanks!!");
                    return res = false;

                }
            }

            // validation method to check if the user want to know mor information about the current student

            static bool Validation2()
            {
                string output;
                output = InvalidInput(valid);
                //string output = Console.ReadLine();
                if (output == "yes" || output == "Yes")
                {
                    return true;
                }
                else //if (output == "No" || output == "no")
                {
                    return false;
                }
            }

            // Static method that return the student FavoriteFood
            static void GetFavoriteFood(string favorit)
            {
                Console.WriteLine($"{names[input]} FavoriteFood is {favoriteFood[input]}.");
                return;
            }

            // static method to return the student HomeTown
            static void GetHomeTown(string home)
            {
                Console.Write($"{names[input]} HomeTown is {homeTown[input]}.");
                return;
            }
            //Method to get the color 
            static void GetColor(string home)
            {
                Console.Write($"{names[input]} Color is {favoriteColor[input]}.");
                return;
            }
            // method to validate an input char Yes or No
            static string InvalidInput(string valid)
            {
                bool repeat = true;
                while (repeat)
                {
                    string output = Console.ReadLine();
                    if (output != "yes" && output != "Yes" && output != "no" && output != "No")
                    {
                        Console.WriteLine("Invalid input. Enter Yes or No?");
                        //return output;
                    }
                    else
                    {
                        repeat = false;
                        return valid = output;

                    }

                }
                return valid;
            }
            // method to validate an input char Y or N
            static char InvalidChar(char validchar)
            {
                Console.WriteLine("Do you want to continu ? y/n ");
                bool repeat = true;
                while (repeat)
                {
                    char outputchar = char.Parse(Console.ReadLine());
                    if (outputchar != 'Y' && outputchar != 'y' && outputchar != 'N' && outputchar != 'n')
                    {
                        Console.WriteLine("Invalid input. Enter Y or N?");
                    }
                    else
                    {
                        repeat = false;
                        return validchar = outputchar;
                    }

                }
                return validchar;
            }
        }
    }
}

