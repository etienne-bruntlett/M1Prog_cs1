namespace als;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("- Je zoekt je sleutel.");
        bool sleutelkwijt = false;
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
