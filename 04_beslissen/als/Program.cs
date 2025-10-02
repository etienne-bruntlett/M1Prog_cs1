namespace als;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("- Je zoekt je sleutel.");
        Console.WriteLine("- Heb je je sleutel gevonden? (Y/N)");
        bool sleutelkwijt = Console.ReadLine() == "N";
        if (sleutelkwijt == true)
        {
            Console.WriteLine("- Je bent je sleutel kwijt!");
            Console.WriteLine("- De deur blijft gesloten.");
        }
        else
        {
            Console.WriteLine("- Je hebt je sleutel gevonden!");
            Console.WriteLine("- Je kan de deur openen.");
        }
    }
}
