namespace basicloop;

class Program
{
    static void Main(string[] args)
    {
        int[] nummers = new int[] { 5, 6, 2 };

        for(int i = 0 ; i< nummers.Length; i++)
        {
            int numbers = nummers[i];
            Console.WriteLine($"{i}: {numbers}");
        }
    }
}
