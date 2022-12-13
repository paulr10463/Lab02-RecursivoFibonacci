using System.Diagnostics;
class Program
{
    static readonly Stopwatch timer = new Stopwatch();
    static void Main(string[] args)
    {
        int n, k;
        do
        {
            Console.Write("Introduzca el número de términos: ");
            n = int.Parse(Console.ReadLine());
        } while (n <= 1);

        Console.Write("\tSerie números de fibonacci recursivo: ");
        timer.Start();
        for (k = 0; k < n; k++)
        {
            Console.Write(new Program().FibonacciRecursivo(k) + " ");
        }
        timer.Stop();
        Console.WriteLine("\n\tElapsed Time: " + timer.Elapsed.ToString());
        
        timer.Reset();
    
        Console.Write("\n\tSerie números de fibonacci iterativo: ");
        timer.Start();
        new Program().FibonacciIterativo(n);
        timer.Stop();
        Console.WriteLine("\n\tElapsed Time: " + timer.Elapsed.ToString());
    }
    long FibonacciRecursivo(int n)
    {
        if (n < 2)
        {
            return n;
        }
        else
        {
            return FibonacciRecursivo(n - 2) + FibonacciRecursivo(n - 1);
        }
    }
    void FibonacciIterativo(int n)
    {
        int i; long ant1, ant2;
        ant1 = ant2 = 1;
        Console.Write("0 1 1 ");
        for (i = 1; i < n - 2; i++)
        {
            long actual = ant1 + ant2;
            Console.Write(actual + " ");
            ant2 = ant1;
            ant1 = actual;
        }

    }
}