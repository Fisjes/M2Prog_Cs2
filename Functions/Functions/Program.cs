namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }
        internal void Vraag1()
        {
            Console.WriteLine("What's nine plus ten?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }

        internal void Vraag2()
        {
            Console.WriteLine("Would you consider pizza to be good?");
            string antwoord = Console.ReadLine();
           
            Console.WriteLine(antwoord);
        }

        internal void Vraag3()
        {
            Console.WriteLine("What do you think of politics?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }

        internal void Vraag4()
        {
            Console.WriteLine("Do you like rhythm games?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }

        internal void Vraag5()
        {
            Console.WriteLine("Do you like Osu! ?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }

        internal void Vraag6()
        {
            Console.WriteLine("What is your favorite movie?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }

        internal void Run()
        {
            Vraag1();
            Vraag2();
            Vraag3();
            Vraag4();
            Vraag5();
            Vraag6();
        }

    }
}