using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvArraysList2
{
    class Program
    {
        static void Main(string[] args)
        {            
            List<Users> users = new List<Users>();

            //Console.WriteLine("Would you like to (create account) or (login)?");
            while (true)
            {
                Console.WriteLine("Would you like to (create account) or (login)?");
                string LogOrCA = Console.ReadLine();

                if(LogOrCA == "create account")
                {
                    while (true)
                    {
                        Console.WriteLine("Enter Username: ");
                        string UsernameC = Console.ReadLine();
                        //check if username exists
                        bool existsC = false;
                        int K = 0;
                        while (K < users.Count)
                        {
                            Users U;
                            U = users[0];
                            if (U.username.Equals(UsernameC))
                            {
                                existsC = true;
                                Console.WriteLine("User already exists");
                                break;
                            }
                            K = K + 1;
                        }
                        if (existsC == false)
                        {
                            Console.WriteLine("Enter Password: ");
                            string PasswordC = Console.ReadLine();
                            users.Add(new Users(UsernameC, PasswordC));
                            break;
                        }                       
                    }
                }

                if(LogOrCA == "login")
                {
                    while (true)
                    {
                        Console.WriteLine("Enter Username: ");
                        string UsernameL = Console.ReadLine();
                        Console.WriteLine("Enter Password: ");
                        string PasswordL = Console.ReadLine();

                        bool existsL = false;
                        int J = 0;
                        while (J < users.Count)
                        {
                            Users U;
                            U = users[0];
                            if (U.username.Equals(UsernameL) && U.password.Equals(PasswordL))
                            {
                                existsL = true;
                                Console.WriteLine("Welcome, " + UsernameL);
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                        }
                        if(existsL == false)
                        {
                            Console.WriteLine("Sorry, account not in records.");
                            break;
                        }
                    }
                }

                else
                {
                    continue;
                }
            }
        }
    }
}
