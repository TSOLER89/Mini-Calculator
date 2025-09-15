using System.Numerics;

namespace Enkel_Miniräknare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till miniräknaren!");
            Console.WriteLine("Välja en operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");



            Console.WriteLine("Ange första talet:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ange andra talet:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            static void Addition(int sum1, int sum2)
            {
                int result = sum1 + sum2;
                Console.WriteLine("Resultat: " + result);
            }
        }
        private static void Subtraktion(int num1, int num2)
        {
            int result = sum1 - sum2;
            Console.WriteLine("Resultat: " + result);
        }
        private static void Multiplikation(int num1, int num2)
        {
            int result = a * b;
            Console.WriteLine("Resultat: " + result);
        }
        private static void Division(int num1, int num2)
        {
            if (b == 0)
            {
                Console.WriteLine("Fel: Division med noll är inte tillåten.");
                return;
            }
            int result = sum1 / sum2;
            Console.WriteLine("Resultat: " + result);
        }
    }
}
            

                switch (choice)
            {
                case 1:
                    IAdditionOperators(num1, num2);
        break;
                case 2:
                    Subtraktion(num1, num2);
                    break;
                case 3:
                    Multiplikation(num1, num2);
                    break;
                case 4:
                    Division(num1, num2);
                    break;
                default:
                    Console.WriteLine("Ogiltig operation.");
                    break;
}
        }   
           
