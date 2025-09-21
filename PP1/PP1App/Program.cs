using System;

class Program
{
    // Método usando fórmula
    static int SumFor(int n)
    {
        return n * (n + 1) / 2;
    }

    // Método usando iteración
    static int SumIte(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        return sum;
    }

    static void Main()
    {
        int Max = int.MaxValue;

        Console.WriteLine("• SumFor:");
        Console.WriteLine($" - From 1 to Max - n: {Ascendente(SumFor, Max).n} → sum: {Ascendente(SumFor, Max).sum}");
        Console.WriteLine($" - From Max to 1 - n: {Descendente(SumFor, Max).n} → sum: {Descendente(SumFor, Max).sum}");

        Console.WriteLine("\n• SumIte:");
        Console.WriteLine($" - From 1 to Max - n: {Ascendente(SumIte, Max).n} → sum: {Ascendente(SumIte, Max).sum}");
        Console.WriteLine($" - From Max to 1 - n: {Descendente(SumIte, Max).n} → sum: {Descendente(SumIte, Max).sum}");
    }

    // Estrategia ascendente
    static (int n, int sum) Ascendente(Func<int, int> metodo, int Max)
    {
        int ultimoN = 1, ultimoSum = metodo(1);
        for (int n = 1; n <= Max; n++)
        {
            int sum = metodo(n);
            if (sum > 0)
            {
                ultimoN = n;
                ultimoSum = sum;
            }
            else break;
        }
        return (ultimoN, ultimoSum);
    }

    // Estrategia descendente
    static (int n, int sum) Descendente(Func<int, int> metodo, int Max)
    {
        for (int n = Max; n >= 1; n--)
        {
            int sum = metodo(n);
            if (sum > 0)
            {
                return (n, sum);
            }
        }
        return (1, metodo(1));
    }
};
