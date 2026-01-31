using System;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            string? input;
            int operationCounter = 0;
            string result = null;

            do
            {
                Console.WriteLine("Welcome to the console calculator!");
                Console.WriteLine("Enter 1 for addition, 2 for subtraction, 3 for multiplication, 4 for division");
                Console.WriteLine("Enter 5 for average of two numbers, and 6 for finding the 5.5% sales tax of a dollar amount");
                Console.WriteLine("Enter exit to escape.");

                int choice = 0;

                input = Console.ReadLine();

                try
                {
                    choice = Convert.ToInt32(input);
                }
                catch(FormatException ex)
                {
                    choice = 0;
                    Console.WriteLine("");
                }


                switch (choice)
                {
                    case 1:
                        double number1 = 0;
                        double number2 = 0;

                        Console.WriteLine("Addition chosen");
                        Console.WriteLine("Choose your first number");
                        number1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Choose your second number");
                        number2 = Convert.ToDouble(Console.ReadLine());

                        double total = number1 + number2;

                        Console.WriteLine(number1 + " plus " + number2 + " = " + total);
                        Console.WriteLine("");
                        operationCounter++;
                        result = "addition";


                        break;

                    case 2:
                        double sub1 = 0;
                        double sub2 = 0;

                        Console.WriteLine("Subtraction chosen");
                        Console.WriteLine("Choose your first number");
                        sub1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Choose your second number");
                        sub2 = Convert.ToDouble(Console.ReadLine());

                        double subTotal = sub1 - sub2;

                        Console.WriteLine(sub1 + " minus " + sub2 + " = " + subTotal);
                        Console.WriteLine("");
                        operationCounter++;
                        result = "subtraction";


                        break;

                    case 3:
                        double mul1 = 0;
                        double mul2 = 0;

                        Console.WriteLine("Multiplication chosen");
                        Console.WriteLine("Choose your first number");
                        mul1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Choose your second number");
                        mul2 = Convert.ToDouble(Console.ReadLine());

                        double mulTotal = mul1 * mul2;

                        Console.WriteLine(mul1 + " times " + mul2 + " = " + mulTotal);
                        Console.WriteLine("");
                        operationCounter++;
                        result = "multiplication";


                        break;

                    case 4:
                        double div1 = 0;
                        double div2 = 0;

                        Console.WriteLine("Division chosen");
                        Console.WriteLine("Choose your first number");
                        div1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Choose your second number");
                        div2 = Convert.ToDouble(Console.ReadLine());

                        if (div2 != 0)
                        {
                            double divTotal = div1 / div2;

                            Console.WriteLine(div1 + " divided by " + div2 + " = " + divTotal);
                            Console.WriteLine("");
                            operationCounter++;
                            result = "division";
                        }
                        else
                        {
                            Console.WriteLine("Sorry divison by zero is not allowed.");
                            Console.WriteLine(" ");
                        }
                        


                        break;

                    case 5:
                        decimal avg1 = 0;
                        decimal avg2 = 0;

                        Console.WriteLine("Average of two numbers chosen");
                        Console.WriteLine("Choose your first number");
                        avg1 = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Choose your second number");
                        avg2 = Convert.ToDecimal(Console.ReadLine());

                        decimal avgTotal = (avg1 + avg2) / 2;

                        Console.WriteLine("The average of " + avg1 + " and " + avg2 + " is " + avgTotal);
                        Console.WriteLine(" ");
                        operationCounter++;
                        result = "average of two numbers";


                        break;

                    case 6:
                        decimal price = 0;

                        Console.WriteLine("Sales tax calculator chosen. 5.5% sales tax will be applied.");
                        Console.WriteLine("Enter your dollar amount");
                        price = Convert.ToDecimal(Console.ReadLine());

                        decimal taxRate = 0.055m; // 5.5% sales tax
                        decimal taxAmount = Math.Round(price * taxRate, 2, MidpointRounding.AwayFromZero);
                        decimal salesTaxTotal = price + taxAmount;
                        string currencyTotal = salesTaxTotal.ToString("C");
                        string currencyPrice = price.ToString("C");


                        Console.WriteLine(currencyPrice + " with 5.5% sales tax applied is equal to " + currencyTotal);
                        Console.WriteLine(" ");
                        operationCounter++;
                        result = "sales tax calculation for " + currencyPrice;

                        break;


                }

            } while (input.ToLower() != "exit");


            Console.WriteLine("Console calculator exited. Goodbye!");
            Console.WriteLine(operationCounter);
            

            

        }
    }
}

