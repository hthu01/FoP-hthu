
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exrcises02
    {
        internal class Exrcises02
        {
            static void Main(string[] args)
            {
                Ex01_1();
                Ex01_2();
                Ex01_3();
                Ex02_1();
                Ex02_2();
                Ex02_3();
                Ex02_4();
                Ex02_5();
            }
        /*Create a C# program to convert from degrees Celsius to Kelvin and Fahrenheit.*/
            static void Ex01_1()
            {
                int c, f, k;
                Console.Write("Enter degrees Celsius: ");
                c = Convert.ToInt32(Console.ReadLine());
                k = c + 273;
                f = c * 18 / 10 + 32;
                Console.WriteLine("Kelvin = " + k);
                Console.WriteLine("Fahrenheit = " + f);
            }
        /*Create a program in C# for calculate the surface and volume of a sphere, given its radius.*/
            static void Ex01_2()
            {
                double r, surface, volume;
                Console.Write("Enter the radius of the sphere: ");
                r = Convert.ToDouble(Console.ReadLine());
                surface = 4 * Math.PI * r * r;
                volume = 4 / 3 * Math.PI * r*r*r;
                Console.WriteLine("The surface of the sphere: " + surface);
                Console.WriteLine("The volume of the sphere: " + volume);
            }
            /*Write a program in C# that calculates the result of adding,
            subtracting, multiplying and dividing two numbers entered by the user.*/
            static void Ex01_3()
            {
                string s1, s2;
                int num1, num2;
                Console.Write("Enter the first number: ");
                s1 = Console.ReadLine();
                Console.Write("Enter the second number: ");
                s2 = Console.ReadLine();
                while ((!int.TryParse(s1,out num1))||(!int.TryParse(s2 , out num2)))
                {
                    Console.WriteLine("You entered invalid numbers. Please re-enter!");
                    Console.Write("Enter the first number: ");
                    s1 = Console.ReadLine();
                    Console.Write("Enter the second number: ");
                    s2 = Console.ReadLine();
                }    
                num1=Convert.ToInt32(s1); num2=Convert.ToInt32(s2);
                int add, subt, multi, div, mod;
                add = num1 + num2;
                subt = num1 - num2;
                multi = num1 * num2;
                div = num1 / num2;
                mod = num1 % num2;
                Console.WriteLine($"{num1} + {num2} = {add}");
                Console.WriteLine($"{num1} - {num2} = {subt}");
                Console.WriteLine($"{num1} * {num2} = {multi}");
                Console.WriteLine($"{num1} / {num2} = {div}");
                Console.WriteLine($"{num1} % {num2} = {mod}");
            }
            /*Write a program in C# that calculates the result of adding,
            subtracting, multiplying and dividing two numbers entered by the user.*/
            static void Ex02_1()
            {
                string s1, s2;
                int num1, num2;
                Console.Write("Enter the first number: ");
                s1 = Console.ReadLine();
                Console.Write("Enter the second number: ");
                s2 = Console.ReadLine();
                while ((!int.TryParse(s1, out num1)) || (!int.TryParse(s2, out num2)))
                {
                    Console.WriteLine("You entered invalid numbers. Please re-enter!");
                    Console.Write("Enter the first number: ");
                    s1 = Console.ReadLine();
                    Console.Write("Enter the second number: ");
                    s2 = Console.ReadLine();
                }
                num1 = Convert.ToInt32(s1); num2 = Convert.ToInt32(s2);
                int add, subt, multi, div, mod;
                add = num1 + num2;
                subt = num1 - num2;
                multi = num1 * num2;
                div = num1 / num2;
                mod = num1 % num2;
                Console.WriteLine($"{num1} + {num2} = {add}");
                Console.WriteLine($"{num1} - {num2} = {subt}");
                Console.WriteLine($"{num1} * {num2} = {multi}");
                Console.WriteLine($"{num1} / {num2} = {div}");
                Console.WriteLine($"{num1} % {num2} = {mod}");
            }
            /*
             * Write a C# Sharp program to display certain values of the function
             *x = y2 + 2y + 1 (using integer numbers for y, ranging from -5 to +5).
             */
            static void Ex02_2()
            {
                Console.WriteLine("Value of the function:");
                for (int i = -5; i <= 5; i++) 
                {
                    Console.WriteLine($"When y={i}, x={i}^2 + 2*{i} + 1 = {i * i + 2 * i + 1}");
                }
            }
            /*Write a C# Sharp program that takes distance and time (hours, minutes, seconds) 
            as input and displays speed in kilometers per hour (km/h) and miles per hour (miles/h).*/
            static void Ex02_3()
            {
                 Console.Write("Enter the distance (km):");
                 double distance = Convert.ToDouble(Console.ReadLine());
                 Console.Write("Enter the time (hours): ");
                 double hours = Convert.ToDouble(Console.ReadLine());
                 Console.Write("Enter the time (minutes): ");
                 double minutes = Convert.ToDouble(Console.ReadLine());
                 Console.Write("Enter the time (seconds): ");
                 double seconds = Convert.ToDouble(Console.ReadLine());
                 minutes = minutes+seconds / 60;
                 hours =hours +minutes / 60;
                 Console.WriteLine("Speed in kilometers per hour (km/h): " + (distance / hours));
                 Console.WriteLine("Speed in miles per hour (miles/h): " + (distance * 0.6214 / hours));
            }
            /*Create a program in C# for calculate the surface and volume of a sphere, given its radius.*/
            static void Ex02_4()
            {
                double r, surface, volume;
                Console.Write("Enter the radius of the sphere: ");
                r = Convert.ToDouble(Console.ReadLine());
                surface = 4 * Math.PI * r * r;
                volume = 4 / 3 * Math.PI * r*r*r;
                Console.WriteLine("The surface of the sphere: " + surface);
                Console.WriteLine("The volume of the sphere: " + volume);
            }
            /*Write a C# Sharp program that takes a character as input and 
            checks if it is a vowel, a digit, or any other symbol.*/
            static void Ex02_5()
             {
                 Console.Write("Enter one character:");
                 char ch= Convert.ToChar(Console.ReadLine());
                 string vow = "ueoai";
                 if ( vow.Contains(ch) )
                 {
                    Console.WriteLine("This character is a vowel.");
                 }
                 else if (char.IsDigit(ch))
                 {
                    Console.WriteLine("This character is a digit.");
                 } else
                 { Console.WriteLine("This character is another symbol."); }
            }
        }
    
    }
