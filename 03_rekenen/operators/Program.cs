namespace operators;

class Program
{
    static void Main(string[] args)
    {
        int plus = 9;

        Console.WriteLine($"plus start is {plus}");
        plus++;
        Console.WriteLine($"plus is nu {plus}");
        plus--;
        Console.WriteLine($"plus is nu {plus}");
        plus--;
        Console.WriteLine($"plus is nu {plus}");
    }
}
