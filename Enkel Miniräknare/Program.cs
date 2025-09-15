using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Välkommen till miniräknaren!");
        Console.WriteLine("Välj en operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraktion");
        Console.WriteLine("3. Multiplikation");
        Console.WriteLine("4. Division");

        int val;
        while (!int.TryParse(Console.ReadLine(), out val) || val < 1 || val > 4)
        {
            Console.Write("Felaktigt val, försök igen (1–4): ");
        }
        int choice = val;

        Console.WriteLine("Ange första talet:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ange andra talet:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine($"Result: {Addition(num1, num2)}");
                break;
            case 2:
                Console.WriteLine($"Result: {Subtract(num1, num2)}");
                break;
            case 3:
                Console.WriteLine($"Result: {Multiply(num1, num2)}");
                break;
            case 4:
                Console.WriteLine($"Result: {Divide(num1, num2)}");
                break;
            default:
                Console.WriteLine("Ogiltigt val.");
                break;
        }
    }

    private static double Addition(double a, double b) => a + b;
    private static double Subtract(double a, double b) => a - b;
    private static double Multiply(double a, double b) => a * b;
    private static double Divide(double a, double b) => b != 0 ? a / b : double.NaN;
}