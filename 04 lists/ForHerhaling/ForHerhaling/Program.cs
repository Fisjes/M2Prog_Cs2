using System;

internal class Formulier
{
    internal int Sterren { get; set; }
    internal string Feedback { get; set; }
}

class Program
{
    static void Main()
    {
        double[] prijzen = new double[] { 0.99, 5.60, 10.11 };
        string[] artiekelen = { "snoepje", "luxe broodje", "lunch menu" };
        Formulier[] formulieren = new Formulier[3];

        formulieren[0] = new Formulier()
        {
            Feedback = "prijzig maar lekker",
            Sterren = 5
        };

        formulieren[1] = new Formulier()
        {
            Feedback = "niet zo lekker",
            Sterren = 2
        };

        formulieren[2] = new Formulier()
        {
            Feedback = "goede kwaliteit",
            Sterren = 4
        };

        for (int i = 0; i < prijzen.Length; i++)
        {
            Console.WriteLine($"Artikel: {artiekelen[i]}, Prijs: {prijzen[i]}, Feedback: {formulieren[i].Feedback}, Sterren: {formulieren[i].Sterren}");
        }
    }
}