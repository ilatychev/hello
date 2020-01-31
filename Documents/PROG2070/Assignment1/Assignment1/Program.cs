/*
 * Program: CPA
 *
 * Purpose: To work with and modify a circle
 *
 * Revision History: Created and Modified
 *                      by Igor Latychev
 *                      on Jan 31, 2020
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarations
            int radius;
            string userInput;
            Circle testCircle;
            double circumference;
            double area;
            bool validInput;
            bool validNumber;
            bool validRadius;
            bool nextOption;

            //Initializations
            radius = 0;
            userInput = "";
            testCircle = new Circle();
            circumference = 0;
            area = 0;
            validInput = true;
            validNumber = true;
            validRadius = true;
            nextOption = true;

            do
            { 
                Console.WriteLine("Please enter the radius for the circle: ");
                try
                {
                    radius = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a number.");
                }

                if (radius <= 0)
                {
                    validNumber = false;
                    Console.WriteLine("Please enter a valid number greater than zero");
                }
                else
                {
                    validNumber = true;
                }
            } while (!validNumber);

            do
            {
                Console.WriteLine("1. Get Circle Radius");
                Console.WriteLine("2. Change Circle Radius");
                Console.WriteLine("3. Get Circle Circumference");
                Console.WriteLine("4. Get Circle Area");
                Console.WriteLine("5. Exit");
                userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    radius = testCircle.GetRadius();
                    Console.WriteLine("Radius Retrieved: " + radius.ToString());
                    nextOption = true;
                }
                else if (userInput == "2")
                {
                    do
                    {
                        Console.WriteLine("Please enter a new radius: ");
                        try
                        {
                            radius = int.Parse(Console.ReadLine());

                            if (radius >= 1)
                            {
                                validRadius = true;
                                testCircle.SetRadius(radius);
                                Console.WriteLine("Radius Successfully Changed: " + testCircle.GetRadius());
                                nextOption = true;
                            }
                            else
                            {
                                validRadius = false;
                                Console.WriteLine("Please enter a valid radius");
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Please enter a number.");
                            validRadius = false;
                        }
                    } while (!validRadius);
                }
                else if (userInput == "3")
                {
                    circumference = testCircle.GetCircumference();
                    Console.WriteLine("The circumference of the circle is: " + circumference);
                    nextOption = true;
                }
                else if (userInput == "4")
                {
                    area = testCircle.GetArea();
                    Console.WriteLine("The area of the circle is: " + area);
                    nextOption = true;
                }
                else if (userInput == "5")
                {
                    Environment.Exit(0);
                }
                else
                {
                    validInput = false;
                }
            } while (!validInput || nextOption == true);
        }
    }
}
