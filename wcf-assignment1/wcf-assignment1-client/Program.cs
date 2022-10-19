using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wcf_assignment1_client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            aaa.Service1Client client = new aaa.Service1Client();
            string choice = "";
            string input = "";
            while (!choice.Equals("6"))
            {
                Console.WriteLine("\t\tCalculator");
                Console.WriteLine("1. Prime number");
                Console.WriteLine("2. Sum of digits");
                Console.WriteLine("3. Reverse a string");
                Console.WriteLine("4. Print HTML tags");
                Console.WriteLine("5. Sort 5 numbers");
                Console.WriteLine("Exit");
                Console.WriteLine("\tEnter your choice: ");

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Input: ");
                        input = Console.ReadLine();
                        Console.WriteLine("Output: " + client.checkPrimeNum(int.Parse(input)));
                        break;
                    case "2":
                        Console.WriteLine("Input: ");
                        input = Console.ReadLine();
                        Console.WriteLine("Output: " + client.checkSumOfDigits(int.Parse(input)));
                        break;
                    case "3":
                        Console.WriteLine("Input: ");
                        input = Console.ReadLine();
                        Console.WriteLine("Output: " + client.reverseAString(input));
                        break;
                    case "4":
                        Console.WriteLine("Tag: ");
                        string tag = Console.ReadLine();
                        Console.WriteLine("Data: ");
                        string data = Console.ReadLine();
                        Console.WriteLine("Output: " + client.printHTMLTags(tag, data));
                        break;
                    case "5":
                        Console.WriteLine("Sort type: ");
                        string sortType = Console.ReadLine();
                        Console.WriteLine("Numbers: ");
                        string numList = Console.ReadLine();
                        Console.WriteLine("Output: " + client.printHTMLTags(sortType, numList));
                        break;
                }
            }
        }
    }
}
