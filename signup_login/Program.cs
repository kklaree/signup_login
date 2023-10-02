using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace signup_login
{
    internal class Program
    {
        static void Menu()
        {
            string user = "";
            string pass = "";
            string userSet = "";
            string passSet = "";

            Console.WriteLine("Main Menu\n");
            Console.WriteLine("[S]ign Up");
            Console.WriteLine("[L]ogin");
            Console.WriteLine("[E]xit\n");
            Console.Write("Select an option: ");
            string option = Console.ReadLine();
            Console.Clear();

            if (option == "S" || option == "s")
            {
                SignUp(userSet, passSet);
            }
            else if (option == "L" || option == "l")
            {
                LogIn(user, pass, userSet, passSet);
            }
            else if (option == "E" || option == "e")
            {
                Environment.Exit(0);
            }
        }

        static void SignUp(string username_set, string password_set)
        {
            Console.WriteLine("SIGN UP\n");
            Console.Write("Username: ");
            username_set = Console.ReadLine();
            Console.Write("Password: ");
            password_set = Console.ReadLine();
            Console.WriteLine("\nAccount created sucessfully");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Login Details:\n");
            Console.WriteLine("Username: " + username_set);
            Console.WriteLine("Password: " + password_set);
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Menu();
        }

        static void LogIn(string username, string password, string username_set, string password_set)
        {
            int attempts = 4;
            Console.WriteLine("LOGIN\n");
            Console.Write("Username: ");
            username = Console.ReadLine();
            Console.Write("Password: ");
            password = Console.ReadLine();

            do
            {
                if (username != username_set || password != password_set)
                {
                    Console.WriteLine("\nTry again");
                    Console.WriteLine("\nYou have " + (attempts - 1) + " attempt/s remaining");
                    attempts--;
                    Console.ReadKey();
                    Console.Clear();

                    if (attempts == 0)
                    {
                        Environment.Exit(0);
                    }

                    Console.WriteLine("LOGIN\n");
                    Console.Write("Username: ");
                    username = Console.ReadLine();
                    Console.Write("Password: ");
                    password = Console.ReadLine();


                }
                if (username == username_set && password == password_set)
                {
                    Console.WriteLine("\nLogin successful");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                }

            }
            while (username != username_set || password != password_set);

        }

        static void Main(string[] args)
        {
            string user = "";
            string pass = "";
            string userSet = "";
            string passSet = "";

            Console.WriteLine("Main Menu\n");
            Console.WriteLine("[S]ign Up");
            Console.WriteLine("[L]ogin");
            Console.WriteLine("[E]xit\n");
            Console.Write("Select an option: ");
            string option = Console.ReadLine();
            Console.Clear();

            if (option == "S" || option == "s")
            {
                SignUp(userSet, passSet);
            }
            else if (option == "L" || option == "l")
            {
                LogIn(user, pass, userSet, passSet);
            }
            else if (option == "E" || option == "e")
            {
                Environment.Exit(0);
            }
        }
    }
}
