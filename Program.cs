using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {

            while (true) 
            {
                Console.WriteLine("Welcome to the console calculator!");
                Console.WriteLine("Enter 1 for addition, 2 for subtraction, 3 for multiplication, 4 for division");
                Console.WriteLine("Enter avg for average of two numbers, and tax for finding the 5.5% sales tax of a dollar amount");

                int choice = 1;
                string input;

                input = Console.ReadLine();
                choice = Convert.ToInt32(input);


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
                        }
                        else
                        {
                            Console.WriteLine("Sorry divison by zero is not allowed.");
                        }


                        break;



                }
            }
            

        }
    }
}

