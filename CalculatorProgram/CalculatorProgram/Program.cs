using System;

namespace CalculatorProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Continue();
            Console.ReadKey();
        }

        public static void Continue()
        {
            do
            {
                var num1 = Num1();
                var operators = OperatorOnly();
                var num2 = Num2();
                var result = Result(num1, num2, operators);
            }
            while (Console.ReadLine().ToUpper() == "Y");
            End();
        }

        public static string End()
        {
            Console.WriteLine("Do you want to continue? (Y = Yes, N = No) : ");
            string input = Console.ReadLine().ToUpper();
                       
            if(input == "Y")
            {
                Continue();
            }
            else if(input == "N")
            {
                Console.WriteLine("Bye!");
            }
            else
            {
                Console.WriteLine("Enter 'Y' or 'N' only");
                input = End();
            }
            return input;
        }

        public static double Num1()
        {
            double num1 = 0;

            try
            {
                Console.Write("\nEnter first number : ");
                num1 = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter numbers only.");
                num1 = Num1();
            }
            return num1;
        }

        public static double Num2()
        {
            double num2 = 0;
            try
            {
                Console.Write("Enter second number : ");
                num2 = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter numbers only.");
                num2 = Num2();
            }            
            return num2;
        }

        public static string OperatorOnly()
        {
            string operators;
            try
            {
                Console.Write("Enter the operation(+ , - , * , /) : ");
                operators = Console.ReadLine();

                if ((operators == "+") || (operators == "-") || (operators == "*") || (operators == "/"))
                {
                    return operators;
                }

                else
                {
                    Console.WriteLine("Enter correct opertor.");
                    operators = OperatorOnly();
                }
            }
            catch
            {
                Console.WriteLine("Enter correct opertor.");
                operators = OperatorOnly();
            }

            if (operators == "+")
            {
                return operators;
            }
            else if (operators == "-")
            {
                return operators;
            }
            else if (operators == "*")
            {
                return operators;
            }
            else if (operators == "/")
            {
                return operators;
            }
            return operators;
        }

        public static double Result(double num1, double num2, string operations)
        {
            double result = 0;

            if (operations == "+")
            {
                result = num1 + num2;
            }
            else if (operations == "-")
            {
                result = num1 - num2;
            }
            else if (operations == "*")
            {
                result = num1 * num2;
            }
            else if (operations == "/")
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Second number should not be zero.");
                    num2 = Num2();
                    result = Result(num1, num2, operations);                    
                }
                else
                {
                    result = num1 / num2;
                }                
            }else              
            result = Result(num1, num2, operations);
            Console.WriteLine($"Result : {num1} {operations} {num2} = {result}.");
            return result;
        }
    }
}
