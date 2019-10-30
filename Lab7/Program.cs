using System;
using System.Text.RegularExpressions;

namespace _11_RegularExpressions
{
    class Class1
    {
        // [STAThread]
        static void Main(string[] args)
        {
            string inputN, inputPh, inputEm, inputDt;
            // Regex phoneExp = new Regex(@"^\(\d{3}\)\d{3}-\d{4}$");
            Regex phoneExp = new Regex(@"\d{3}-\d{3}-\d{4}$");
            Regex name = new Regex(@"^[A-Z]([a-zA-Z]){1,29}$");
            Regex date = new Regex(@"([0][1-9]|[1][0-9]|[2][0-9]|[3][0-1])\/([0][1-9]|[1][0-2])\/[1-2][0-9][0-9][0-9]");
            Regex email = new Regex(@"[A-Za-z]{5,30}@{1}[A-Za-z]{5,10}\.{1}[A-Za-z]{2,3}$");

            Console.Write("Enter The Name: ");
            inputN = Console.ReadLine();
            while (name.Match(inputN).Success == false)
            {
                Console.WriteLine("Sorry, name is not valid");
                Console.Write("Enter the name: ");
                inputN = Console.ReadLine();
            }
            Console.WriteLine("Name is valid!");

            Console.Write("Enter a phone number: ");
            inputPh = Console.ReadLine();

            while (phoneExp.Match(inputPh).Success == false)
            {
                Console.WriteLine("Sorry, phone number is not valid");
                Console.Write("Enter a phone number: ");
                inputPh = Console.ReadLine();
            }
            Console.WriteLine("phone number is valid!");

            Console.Write("Enter a Date: ");
            inputDt = Console.ReadLine();

            while (date.Match(inputDt).Success == false)
            {
                Console.WriteLine("Sorry, Date is not valid");
                Console.Write("Enter a Date: ");
                inputDt = Console.ReadLine();
            }
            Console.WriteLine("Date is valid!");

            Console.Write("Enter The Email: ");
            inputEm = Console.ReadLine();
            while (email.Match(inputEm).Success == false)
            {
                Console.WriteLine("Sorry, Email is not valid");
                Console.Write("Enter the Email: ");
                inputEm = Console.ReadLine();
            }
            Console.WriteLine("Email is valid!");



            Console.WriteLine("Validated!");
        }
    }
}