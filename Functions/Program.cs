using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimene arv:");
            int userNumberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta teine arv:");
            int userNumberTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Palun vali tehe: (sisesta '+', '/', '*' või '-') ");
            char userOperator = Convert.ToChar(Console.ReadLine());

            switch (userOperator)
            {
                case '+':
                    AddToNumbers(userNumberOne, userNumberTwo);
                    break;
                case '/':
                    DivideToNumbers(userNumberOne, userNumberTwo);
                    break;
                case '*':
                    MultiplyToNumbers(userNumberOne, userNumberTwo);
                    break;
                case '-':
                    SubtractToNumbers(userNumberOne, userNumberTwo);
                    break;
                default:
                    Console.WriteLine("Kena päeva!");
                    break;
            }


        }

        private static void AddToNumbers(int x, int y)
        {
            int result = x + y;
            Console.WriteLine(result);
        }

        public static void DivideToNumbers(double x, double y)
        {
           double result = x / y;
           Console.WriteLine(result);
        }
        public static void MultiplyToNumbers(int x, int y)
        {
            int result = x * y;
            Console.WriteLine(result);
        }
        public static void SubtractToNumbers(int x, int y)
        {
            int result = x - y;
            Console.WriteLine(result);
        }


    }
}
