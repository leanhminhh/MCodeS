using System;

class ApproximationCalculator
{
    public static double ApproximatePi(double epsilon)
    {
        double sum = 0;
        double term;
        int n = 0;

        do
        {
            term = Math.Pow(-1, n) / (2 * n + 1);
            sum += term;
            n++;
        } while (Math.Abs(term) >= epsilon && n < 10000);
        return sum * 4;
    }

    public static double ApproximateSin(double x, double epsilon)
    {
        double term = x;
        double sum = x;
        int n = 1;

        while (Math.Abs(term) >= epsilon && n < 10000)
        {
            term *= -1 * Math.Pow(x, 2) / ((2 * n) * (2 * n + 1));
            sum += term;
            n++;
        }

        return sum;
    }

    public static double ApproximateLn(double x, double epsilon)
    {
        if (x <= -1)
        {
            Console.WriteLine("Error: x must be greater than -1 for ln(1+x).");
            return double.NaN;
        }

        double term = x;
        double sum = term;
        int n = 2;

        while (Math.Abs(term) >= epsilon && n < 10000)
        {
            term *= -1 * x * (n - 1) / n;
            sum += term;
            n++;
        }

        return sum;
    }

    public static double ApproximateCos(double x, double epsilon)
    {
        double term = 1;
        double sum = 1;
        int n = 1;

        while (Math.Abs(term) >= epsilon && n < 10000)
        {
            term *= -1 * Math.Pow(x, 2) / ((2 * n - 1) * (2 * n));
            sum += term;
            n++;
        }

        return sum;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter epsilon (accuracy): ");
        double epsilon = double.Parse(Console.ReadLine());

        Console.WriteLine($"Approximated π = {ApproximationCalculator.ApproximatePi(epsilon):F6}");

        Console.Write("Enter x for sin(x), ln(x), cos(x): ");
        double x = double.Parse(Console.ReadLine());

        Console.WriteLine($"sin(x) = {ApproximationCalculator.ApproximateSin(x, epsilon):F6}");
        double lnResult = ApproximationCalculator.ApproximateLn(x, epsilon);
        if (!double.IsNaN(lnResult))
        {
            Console.WriteLine($"ln(1+x) = {lnResult:F6}");
        }
        Console.WriteLine($"cos(x) = {ApproximationCalculator.ApproximateCos(x, epsilon):F6}");
    }
}
