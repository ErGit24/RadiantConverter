using System;
using static System.Console;


namespace LabConsolesssssss
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Indtast vinklen i gradder min ven:");
            if (int.TryParse(ReadLine(), out int gradder))
            {
                double radianz = GraderTilRadianz(gradder);
                WriteLine($"Tak min ven\n{gradder} grader er {radianz:F2} radianz.");
            }
            else
            {
                WriteLine("HALLO Ugyldig indtast. Indtast et heltal min ven.");
            }
        }
        static double GraderTilRadianz(int gradder)
        {
            return gradder * (Math.PI / 180);
        }
    }
}
