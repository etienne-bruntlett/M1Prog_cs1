namespace stappen;

class Program
{
    static void Main(string[] args)
    {
        float[] vectors = new float[] {
           6, 7, 8,
           1, 4, 0
       };

        for (int i = 0; i < vectors.Length; i+=3)
        {
            float vector = vectors[i];
            Console.WriteLine($"vector vanaf index {i}: ({vectors[i]}, {vectors[i+1]}, {vectors[i+2]})");
        }
    }
}
