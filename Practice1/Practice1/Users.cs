using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Azure.Mobile.Server.Notifications;
using Org.BouncyCastle.Crypto.Generators;
using BCrypt.Net;

namespace Practice1
{
    public class Users
    {
        System.Collections.Stack myPass = new System.Collections.Stack();
        public void Register()
        {
            string answer = "millipede";
            Console.WriteLine("Answer a Security Question\nWhat is my most recently aquired pet?");
            string answerInput = Console.ReadLine();

            if (answer == answerInput)
            {
                Console.WriteLine("Enter New Credentials to Register");

                string submittedPasscode = Console.ReadLine();
                string newPass = BCrypt.Net.BCrypt.HashPassword(submittedPasscode);

                myPass.Push(newPass);

                Console.WriteLine("Press 'n' to proceed to login");
                string next = Console.ReadLine();
                string characterKey = "n";
                do
                {
                    if (characterKey == next)
                    {
                        LogIn();
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }
                } while (characterKey != next);
            }
            else
            {
                Console.WriteLine("Wrong Answer!!!");
                Environment.Exit(0);
            }
        }
       public void LogIn()
        {
            string enterPass;

            Console.WriteLine("Enter Password");
            enterPass = Console.ReadLine();

            for(int i = 0; i < myPass.Count; i++)
            {
                string hashedPassword = myPass.Pop().ToString();

                bool validPassword = BCrypt.Net.BCrypt.Verify(enterPass, hashedPassword);
                if (validPassword)
                {
                    Console.WriteLine("Login Success");
                }
                else
                {
                    Console.WriteLine("Invalid Attempt");
                }
            }
        }
    }
}
