namespace en;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("- Zit de deur op slot? Y/N");
        bool doorNeedsKey = Console.ReadLine() = "Y";
        if (doorNeedsKey == true)
        {
            Console.WriteLine("- Heb je een sleutel? Y/N");
            bool hasKey = Console.ReadLine() = "Y";
            if (hasKey == true)
            {
                Console.WriteLine("- Je gebruikt de sleutel om de deur te openen.");
            }
            else
            {
                Console.WriteLine("- Je hebt geen sleutel.");
                Console.WriteLine("- De deur blijft op slot.");
            }
        }
        else
        {
            Console.WriteLine("- Je opent de deur.");
        }
    }
}
