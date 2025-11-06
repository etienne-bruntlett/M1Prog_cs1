namespace autoclass;

class Program
{
    static void Main(string[] args)
    {
        Auto mijnAuto = new Auto();
        mijnAuto.merk = "BMW";
        mijnAuto.bouwjaar = 2010;
        Console.WriteLine(mijnAuto);

        Console.WriteLine("Auto merk: " + mijnAuto.merk);
        Console.WriteLine("Auto bouwjaar: " + mijnAuto.bouwjaar);
        Console.WriteLine("");

        mijnAuto.merk = "Volkswagon";
        mijnAuto.bouwjaar = 2015;

        Console.WriteLine("Tweede Auto");
        Console.WriteLine("Auto merk: " + mijnAuto.merk);
        Console.WriteLine("Auto bouwjaar: " + mijnAuto.bouwjaar);
    }
}
