using System;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Users userClass = new Users();
            ReportCard rc = new ReportCard();

            string newUser = "n";
            string firstInput;
            string user = "e";

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
                    Console.WriteLine("Input is invalid. Try again.");
                }
            } while (firstInput != newUser || firstInput != user);
        }
}
