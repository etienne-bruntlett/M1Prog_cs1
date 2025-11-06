namespace student;

class Program
{
    static void Main(string[] args)
    {
        Student studenten = new Student();
        studenten.naam = "Robert Robertson";
        studenten.leeftijd = 26;
        studenten.studentNummer = 582937;

        Console.WriteLine("Student Naam: " + studenten.naam);
        Console.WriteLine("Student Leeftijd: " + studenten.leeftijd);
        Console.WriteLine("Student Nummer: " + studenten.studentNummer);
        Console.WriteLine("");

        studenten.naam = "Courtney";
        studenten.leeftijd = 27;
        studenten.studentNummer = 920573;

        Console.WriteLine("Student Naam: " + studenten.naam);
        Console.WriteLine("Student Leeftijd: " + studenten.leeftijd);
        Console.WriteLine("Student Nummer: " + studenten.studentNummer);
    }
}
