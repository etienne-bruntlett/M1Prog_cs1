namespace forif;

class Program
{
    static void Main(string[] args)
    {
        int[] nummers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        for (int i = 3 ; i < 8; i++)
        {
            int numbers = nummers[i];
            Console.WriteLine($"{numbers}");
        }
    }
}
