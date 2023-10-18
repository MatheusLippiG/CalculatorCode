using System;

namespace CalculatorCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("-----CALCULATOR-----");
            Console.WriteLine("Choose your option");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine("5 - Percentage - Products discount");
            Console.WriteLine("6 - Exit");

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1: Addition(); break;
                case 2: Subtraction(); break;
                case 3: Multiplication(); break;
                case 4: Division(); break;
                case 5: Percentage(); break;
                case 6: Exit(); break;
                default: Menu(); break;
            }
        }
        static void Addition()
        {
            Console.Clear();
            Console.WriteLine("First value:");
            float value1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Second value:");
            float value2 = float.Parse(Console.ReadLine());

            float equals = value1 + value2;
            Console.WriteLine($"The result is: {equals}");
            Console.ReadKey();
            Menu();
        }
        static void Subtraction()
        {
            Console.Clear();
            Console.WriteLine("First value:");
            float value1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Second value:");
            float value2 = float.Parse(Console.ReadLine());

            float equals = value1 - value2;
            Console.WriteLine($"The result is: {equals}");
            Console.ReadKey();
            Menu();
        }
        static void Multiplication()
        {
            Console.Clear();
            Console.WriteLine("First value:");
            float value1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Second value:");
            float value2 = float.Parse(Console.ReadLine());

            float equals = value1 * value2;
            Console.WriteLine($"The result is: {equals}");
            Console.ReadKey();
            Menu();
        }
        static void Division()
        {
            Console.Clear();
            Console.WriteLine("First value:");
            float value1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Second value:");
            float value2 = float.Parse(Console.ReadLine());

            float equals = value1 / value2;
            Console.WriteLine($"The result is: {equals}");
            Console.ReadKey();
            Menu();
        }
        static void Percentage()
        {
            Console.Clear();
            Console.WriteLine("Product value:");
            float value1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Discount value:");
            float value2 = float.Parse(Console.ReadLine());

            float equals = (value1 * value2) / 100;

            Console.WriteLine($"The value with {value2}% of discount is: {equals}");
            Console.ReadKey();
            Menu();
        }
        static void Exit()
        {
            Console.Clear();
            Console.WriteLine("Exiting...");
            System.Environment.Exit(0);
        }
    }
}