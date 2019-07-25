using System;

namespace MathEquationsPart2
{
    class Program
    {
        static void circleCirc()
        {         
            // Circumference and area of a circle
            try
            {              
                Console.WriteLine("\nPart 1, circumference of a circle.");
                Console.Write("Enter an integer for the radius: ");
                string strradius = Console.ReadLine();
                int v = int.Parse(strradius);
                bool positive = true;
                positive = v >= 1;
                
                if (positive)
                {                                   
                    double circumference = 2 * Math.PI * v;
                    double controlled = checked(circumference);
                    Console.WriteLine($"The circumference is {controlled}");
                }
                else
                {
                    Console.WriteLine("Enter positive numbers!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Don't enter letters!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Enter smaller number!");
            }
        }
        static void circleArea()
        {
            // Implementation for area here          
            try
            {
                Console.WriteLine("\n Part 2, Area of cirlce.");
                Console.Write("Enter integer for the radius:  ");
                string strradius2 = Console.ReadLine();
                int v = int.Parse(strradius2);
                bool positive = true;
                positive = v >= 1;

                if (positive)
                {
                    double area = Math.PI * v * v;
                    double uncontrolled = unchecked(area);
                    Console.WriteLine($"The area is {uncontrolled}");
                }
                else 
                {
                    Console.WriteLine("Enter Positive numbers!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Don't enter letters!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Enter smaller number!");
            }
        }
        static void triangleArea()
        {
            try
            {
                // Area of a triangle, given the lengths of the side
                Console.WriteLine("\nPart 3, area of a triangle (Heron's formula).");
                Console.Write("Enter integer for the first length:    ");
                string lengtha = Console.ReadLine();
                int v1 = int.Parse(lengtha);
                Console.Write("Enter the integer for the second length:  ");
                string lengthb = Console.ReadLine();
                int v2 = int.Parse(lengthb);
                Console.Write("Enter integer for the last length:  ");
                string lengthc = Console.ReadLine();
                int v3 = int.Parse(lengthc);
                bool positive = true;
                positive = (v1 >= 1) && (v2 >= 1) && (v3 >= 1);

                if (positive)
                {
                    double areaofT = (v1 + v2 + v3) / 2;
                    double controlled = checked(areaofT);
                    Console.WriteLine($"The area of a triangle is {controlled}");
                }
                else
                {
                    Console.WriteLine("Enter positive numbers!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Don't enter letters!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Enter smaller numbers!");
            }
        }
        static void hemisphereVolume()
        {
            try
            {
                //Volume of a hemisphere
                Console.WriteLine("\nPart 4, volume of a hemisphere.");
                Console.Write("Enter integer for the radius:   ");
                string hemisphere = Console.ReadLine();
                int v = int.Parse(hemisphere);
                bool positive = true;
                positive = v >= 1;

                if (positive)
                {
                    double volume = ((4 / 3) * Math.PI * v * v * v) / 2;
                    double uncontrolled = unchecked(volume);
                    Console.WriteLine($"The volume is {uncontrolled}");
                }
                else
                {
                    Console.WriteLine("Enter positive numbers!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Don't enter letters!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Enter smaller numbers!");
            }
        }
        static void quadraticFormula()
        {
            try
            {
                //Solving a quadtratic equation
                Console.WriteLine("\nPart 5, solving a quadratic formula.");
                Console.Write("Enter an integer for a:   ");
                string valuea = Console.ReadLine();
                int v1 = int.Parse(valuea);
                Console.Write("Enter an integer for value b:  ");
                string valueb = Console.ReadLine();
                int v2 = int.Parse(valueb);
                Console.Write("Enter an integer for c:   ");
                string valuec = Console.ReadLine();
                int v3 = int.Parse(valuec);
                bool positive = true;
                positive = (v1 >= 1) && (v2 >= 1) && (v3 >= 1);

                if (positive)
                {
                    double quadratic = (-v2) + Math.Sqrt((v2 * v2) - ((4) * (v1) * (v3))) / (2) * (v1);
                    double quadratik = (-v2) - Math.Sqrt((v2 * v2) - ((4) * (v1) * (v3))) / (2) * (v1);
                    double controlled1 = checked(quadratic);
                    double controlled2 = checked(quadratik);
                    Console.WriteLine($"The answer to this quadratic equation is {controlled1}");
                    Console.WriteLine($"The answer to this quadratic equation is {controlled2}");
                }
                else
                {
                    Console.WriteLine("Enter positive numbers!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Try again and enter a number!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Enter a smaller numbers!");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                circleCirc();
                circleArea();
                triangleArea();
                hemisphereVolume();
                quadraticFormula();
            }
            catch(Exception)
            {
                Console.WriteLine("\nFollow instructions!");
            }
            finally
            {
                Console.WriteLine("This program has finally terminated");
            }
        }
    }
}
