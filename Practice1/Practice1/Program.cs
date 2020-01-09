using System;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Users userClass = new Users();
            ReportCard rc = new ReportCard();

            rc.Data();

            string newUser = "n";
            string firstInput;
            string user = "e";
            bool x = false;

            do
            {
                Console.WriteLine("Press 'e' to enter in Login Credentials. If you are a new user, press 'n' to sign up for an account.");
                firstInput = Console.ReadLine();
                if (firstInput == newUser)
                {
                    userClass.Register();
                }
                else if (firstInput == user)
                {
                    userClass.LogIn();
                }
                else
                {
                    x = true;
                    Console.WriteLine("Input is invalid. Try again.");
                }

            } while (x);

            Console.WriteLine("Press any key to view Report Card");
            Console.ReadLine();
            rc.DisplayData();
            Console.ReadLine();
        }
    }
}
