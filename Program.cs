using System;
using System.Collections.Generic;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            string? input;
            int operationCounter = 0;
            string? result = null;
            int additionCounter = 0;
            int subtractionCounter = 0;
            int multiplicationCounter = 0;
            int divisionCounter = 0;
            int averageCounter = 0;
            int salestaxCounter = 0;


            do
            {
                Console.WriteLine("Welcome to the console calculator!");
                Console.WriteLine("Enter 1 for addition.");
                Console.WriteLine("Enter 2 for subtraction.");
                Console.WriteLine("Enter 3 for multiplication.");
                Console.WriteLine("Enter 4 for division.");
                Console.WriteLine("Enter 5 for average of two numbers.");
                Console.WriteLine("Enter 6 for finding the 5.5% sales tax of a dollar amount.");
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
                        decimal number1 = 0;
                        decimal number2 = 0;

                        Console.WriteLine("Addition chosen");
                        while (true)
                        {
                            Console.WriteLine("Choose your first number");
                            try
                            {
                                number1 = Convert.ToDecimal(Console.ReadLine());
                                break;
                            }
                            catch (FormatException ex)
                            {
                                continue;
                            }
                        }
                       
                        while (true)
                        {
                            Console.WriteLine("Choose your second number");
                            try
                            {
                                number2 = Convert.ToDecimal(Console.ReadLine());
                                break;
                            }
                            catch (FormatException ex)
                            {
                                continue;
                            }
                        }

                        decimal total = number1 + number2;

                        Console.WriteLine(number1 + " plus " + number2 + " is " + total);
                        Console.WriteLine("");
                        operationCounter++;
                        additionCounter++;
                        result = "addition";

                        break;

                    case 2:
                        decimal sub1 = 0;
                        decimal sub2 = 0;

                        Console.WriteLine("Subtraction chosen");
                        while (true)
                        {
                            Console.WriteLine("Choose your first number");
                            try
                            {
                                sub1 = Convert.ToDecimal(Console.ReadLine());
                                break;
                            }
                            catch (FormatException ex)
                            {
                                continue;
                            }
                        }

                        while (true)
                        {
                            Console.WriteLine("Choose your second number");
                            try
                            {
                                sub2 = Convert.ToDecimal(Console.ReadLine());
                                break;
                            }
                            catch (FormatException ex)
                            {
                                continue;
                            }
                        }

                        decimal subTotal = sub1 - sub2;

                        Console.WriteLine(sub1 + " minus " + sub2 + " is " + subTotal);
                        Console.WriteLine("");
                        operationCounter++;
                        subtractionCounter++;
                        result = "subtraction";


                        break;

                    case 3:
                        decimal mul1 = 0;
                        decimal mul2 = 0;

                        Console.WriteLine("Multiplication chosen");

                        while (true)
                        {
                            Console.WriteLine("Choose your first number");
                            try
                            {
                                mul1 = Convert.ToDecimal(Console.ReadLine());
                                break;
                            }
                            catch (FormatException ex)
                            {
                                continue;
                            }
                        }
                        while (true)
                        {
                            Console.WriteLine("Choose your second number");
                            try
                            {
                                mul2 = Convert.ToDecimal(Console.ReadLine());
                                break;
                            }
                            catch (FormatException ex)
                            {
                                continue;
                            }
                        }

                        decimal mulTotal = mul1 * mul2;

                        Console.WriteLine(mul1 + " times " + mul2 + " is " + mulTotal);
                        Console.WriteLine("");
                        operationCounter++;
                        multiplicationCounter++;
                        result = "multiplication";
                        
                        break;

                    case 4:
                        decimal div1 = 0;
                        decimal div2 = 0;

                        Console.WriteLine("Division chosen");

                        while (true)
                        {
                            Console.WriteLine("Choose your first number");
                            try
                            {
                                div1 = Convert.ToDecimal(Console.ReadLine());
                                break;
                            }
                            catch (FormatException ex)
                            {
                                continue;
                            }
                        }
                        while (true)
                        {
                            Console.WriteLine("Choose your second number");
                            try
                            {
                                div2 = Convert.ToDecimal(Console.ReadLine());

                                if (div2 != 0)
                                {
                                    decimal divTotal = div1 / div2;

                                    Console.WriteLine(div1 + " divided by " + div2 + " is " + divTotal);
                                    Console.WriteLine("");
                                    operationCounter++;
                                    divisionCounter++;
                                    result = "division";
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Sorry divison by zero is not allowed.");
                                    Console.WriteLine(" ");
                                }
                            }
                            catch (FormatException ex)
                            {
                                continue;
                            }
                        }

                        break;

                    case 5:
                        decimal avg1 = 0;
                        decimal avg2 = 0;

                        Console.WriteLine("Average of two numbers chosen");

                        while (true)
                        {
                            Console.WriteLine("Choose your first number");
                            try
                            {
                                avg1 = Convert.ToDecimal(Console.ReadLine());
                                break;
                            }
                            catch (FormatException ex)
                            {
                                continue;
                            }
                        }
                        while (true)
                        {
                            Console.WriteLine("Choose your second number");
                            try
                            {
                                avg2 = Convert.ToDecimal(Console.ReadLine());
                                break;
                            }
                            catch (FormatException ex)
                            {
                                continue;
                            }
                        }

                        decimal avgTotal = (avg1 + avg2) / 2;

                        Console.WriteLine("The average of " + avg1 + " and " + avg2 + " is " + avgTotal);
                        Console.WriteLine(" ");
                        operationCounter++;
                        averageCounter++;
                        result = "average of two numbers";


                        break;

                    case 6:
                        decimal price = 0;

                        Console.WriteLine("Sales tax calculator chosen. 5.5% sales tax will be applied.");

                        while (true)
                        {
                            Console.WriteLine("Enter your dollar amount");
                            try
                            {
                                price = Convert.ToDecimal(Console.ReadLine());
                                break;
                            }
                            catch (FormatException ex)
                            {
                                continue;
                            }
                        }

                        decimal taxRate = 0.055m; // 5.5% sales tax
                        decimal taxAmount = Math.Round(price * taxRate, 2, MidpointRounding.AwayFromZero);
                        decimal salesTaxTotal = price + taxAmount;
                        string currencyTotal = salesTaxTotal.ToString("C");
                        string currencyPrice = price.ToString("C");


                        Console.WriteLine(currencyPrice + " with 5.5% sales tax applied is equal to " + currencyTotal);
                        Console.WriteLine(" ");
                        operationCounter++;
                        salestaxCounter++;
                        result = "sales tax calculation for " + currencyPrice;

                        break;


                }

            } while (input.ToLower() != "exit");


            Console.WriteLine("Console calculator exited. Goodbye!");
            Console.WriteLine("You performed " + operationCounter + " successful calculations.");

            Console.WriteLine("You did addition " + additionCounter + " times.");
            Console.WriteLine("You did subtraction " + subtractionCounter + " times.");
            Console.WriteLine("You did multiplication " + multiplicationCounter + " times.");
            Console.WriteLine("You did division " + divisionCounter + " times.");
            Console.WriteLine("You found the average of two numbers " + averageCounter + " times.");
            Console.WriteLine("You found the sales tax " + salestaxCounter + " times.");

            Console.WriteLine("The last calculation done was " + result);



        }
    }
}

