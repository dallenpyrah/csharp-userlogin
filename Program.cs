using System;
using System.Collections.Generic;

namespace morning_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionary<string, string> userLogin = new Dictionary<string, string>();
            // userLogin.Add("dallenpyrah@gmail.com", "Oregon81");
            // userLogin.Add("bigboityron@gmail.com", "Henevermisses");
            // userLogin.Add("anotherbigone@gmail.com", "Whatdoyoumeme");
            // userLogin.Add("johncenascat@gmail.com", "howinthehell");
            // Console.WriteLine("Login to the mainframe...");
            // Console.WriteLine(userLogin);

            // ConsoleKeyInfo userInput = System.Console.ReadKey();

            var userDatabase = new Dictionary<string, string>()
        {
            {"dallenpyrah@gmail.com", "bigchimp"},
            {"johncena@gmail.com", "bigsmasher"},
            {"bigboyjohn@gmail.com", "anothersmasher"},
            {"iguanasarecool@gmail.com", "dontlookatit"},
            {"cowsdontwalk@gmail.com", "cowsalwayswalk"},
            {"itsbillgates@gmail.com", "igotalotofmoney"}
        };
            Console.WriteLine("Login to the mainframe...");
            Console.WriteLine("Email: ");
            string userInput = System.Console.ReadLine();
            if (userDatabase.ContainsKey(userInput))
            {
                Console.WriteLine("Password: ");
                string userPassword = System.Console.ReadLine();
                if (userPassword == userDatabase[userInput])
                {
                    Console.WriteLine("You are in the mainframe");
                }
                else
                {
                    Console.WriteLine("Wrong Password");
                }
            }
            else
            {
                Console.WriteLine("Wrong email");
            }

        }
    }
}
