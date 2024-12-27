using System;

namespace MathFormulas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"S1 = {FormulaCalculator.CalculateS1(n):F6}");
            Console.WriteLine($"S2 = {FormulaCalculator.CalculateS2(n):F6}");
            Console.WriteLine($"S5 = {FormulaCalculator.CalculateS5(n):F6}");
            Console.WriteLine($"S6 = {FormulaCalculator.CalculateS6(n):F6}");
            Console.WriteLine($"S7 = {FormulaCalculator.CalculateS7(n):F6}");
        }
    }

    class FormulaCalculator
    {
        public static double CalculateS1(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                double denominator = 0;
                for (int j = 1; j <= i; j++)
                {
                    denominator += Math.Pow(j, 2);
                }
                sum += Math.Pow(-1, i + 1) / denominator;
            }
            return sum;
        }

        public static double CalculateS2(int n)
        {
            double sum = 1;
            double term = 1;
            for (int i = 1; i <= n; i++)
            {
                term *= -2.0 / i;
                sum += term;
            }
            return sum;
        }

        public static double CalculateS5(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += Math.Pow(-1, i + 1) * 1.0 / (2 * i);
            }
            return sum;
        }

        public static double CalculateS6(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                double denominator = 0;
                for (int j = 1; j <= i; j++)
                {
                    denominator += j;
                }
                sum += Math.Pow(-1, i + 1) / denominator;
            }
            return sum;
        }

        public static double CalculateS7(int n)
        {
            double sum = 1;
            double term = 1;
            for (int i = 1; i <= n; i++)
            {
                term *= 2.0 / i;
                sum += term;
            }
            return sum;
        }
    }
}
