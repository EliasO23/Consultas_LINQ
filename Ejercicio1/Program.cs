// See https://aka.ms/new-console-template for more information
using System.Linq;

class Consulta
{
    static void Main()
    {
        int[] scores = { 97, 92, 81, 60 };

        var Query =
            from num in scores
            where num > 80
            select num;

        Console.WriteLine("Resultado de la consulta:");
        foreach (var iten in Query)
        {
            Console.Write(" " + iten.ToString() );
        }
        Console.WriteLine("\n");
    }
}
