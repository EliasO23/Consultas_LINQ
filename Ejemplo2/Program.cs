// See https://aka.ms/new-console-template for more information
using System.Linq;

class Consulta
{
    static void Main()
    {
        int[] score = { 90, 71, 82, 93, 75, 82 };

        var Query =
            from num in score
            where num > 80
            orderby num descending
            select num;

        Console.WriteLine("Resultados de la consulta: ");
        foreach (var item in Query)
        {
            Console.WriteLine($" - {item}");
        }

    }

}
