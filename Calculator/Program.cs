using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstValue;
            double secondValue;

            Intro();

            void Intro()
            {
                int operand;

                Console.WriteLine("Enter First Number Then Press Enter to Continue...");
                firstValue = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Enter Second Number Then Press Enter to Continue...");
                secondValue = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Select an Operand Number...\n 1 for Addition \n 2 for Subrtraction \n 3 for Multiplication \n 4 for Division");
                Console.WriteLine("Any Other Selection is Invalid in this Context");
                Int32.TryParse(Console.ReadLine(), out operand);
               
                switch (operand)
                {
                    case 1:
                        Add(firstValue, secondValue);
                        Console.WriteLine("Exits on Enter...");
                        Console.ReadLine();
                        break;

                    case 2:
                        Subtract(firstValue, secondValue);
                        Console.WriteLine("Exits on Enter...");
                        Console.ReadLine();
                        break;

                    case 3:
                        Multiply(firstValue, secondValue);
                        Console.WriteLine("Exits on Enter...");
                        Console.ReadLine();
                        break;

                    case 4:
                        Divide(firstValue, secondValue);
                        Console.WriteLine("Exits on Enter...");
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Invalid!");
                        Intro();
                        break;
                }
            }

           double Add(double first, double second)
            {
                double addAnswer = first + second;
                Console.WriteLine("Your answer is " + addAnswer);
                return addAnswer;
            }

            double Subtract(double first, double second)
            {
                double sAnswer = first - second;
                Console.WriteLine("Your answer is " + sAnswer);
                return sAnswer;
            }

            double Multiply(double first, double second)
            {
                double mAnswer = first * second;
                Console.WriteLine("Your answer is " + mAnswer);
                return mAnswer;
            }

            double Divide(double first, double second)
            {
                double dAnswer = first / second;
                Console.WriteLine("Your answer is " + dAnswer);
                return dAnswer;
            }
        }
    }
}
