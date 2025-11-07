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

        Student student2 = new Student();
        student2.naam = "Courtney";
        student2.leeftijd = 27;
        student2.studentNummer = 920573;

        Console.WriteLine("Student Naam: " + student2.naam);
        Console.WriteLine("Student Leeftijd: " + student2.leeftijd);
        Console.WriteLine("Student Nummer: " + student2.studentNummer);

        studenten.ToonNaam();
        student2.ToonNaam();

        Student jeroen = new Student();
        jeroen.naam = "Jeroen";

        jeroen.Verjaar();
        jeroen.ToonLeeftijd();
    }
}
