namespace stringclass;

class Program
{
    static void Main(string[] args)
    {
        string[] random = new string[] { "16", "VOORBEELD STRING", "global" };

        string[] geenCaps = new string[] { "global", "variabele", "class" };

        for (int i = 0; i < random.Length; i++)
        {
            string things = random[i];
            Console.WriteLine($"{things}");
        }

        for (int i = 0; i < geenCaps.Length; i++)
        {
            string lijst = geenCaps[i];
            Console.WriteLine(lijst);
            Console.WriteLine($"is een string die {lijst.Length} letters lang is");
            Console.WriteLine(lijst.ToUpper());
        }
    }
}
