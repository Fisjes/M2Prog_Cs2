namespace Functions
{
    internal class Program
    {
        Random rnd = new();
        string[] vragen = new string[]
            {
                "Wat is je naam","Wat is 9 + 10?","Wie is de huidige president van Amerika?","Pizza margherita of pizza salami?","Wat is een Sigma?"
            };

        static void Main(string[] args) //return type = void
        {
            Program program = new Program(); //hier word de variable program aangemaakt
            program.Run();
        }

        private void Run()
        {
            Console.WriteLine("Antwoord met ja of nee");
            Vraag1();
            string Vraag0 = GetVraag(0);
            Console.WriteLine(Vraag0);
            string antwoord7 = Vraag7();
            Console.WriteLine(antwoord7);
        }

        internal void AskRandomQuestion()
        {
            string vraag = GetRandomVraag();
            int vraagIndex = rnd.Next(vragen.Length);
        }


        internal string GetVraag(int vraagIndex)
        {

            return vragen[vraagIndex];

        }

        internal void Vraag1()
        {
            Console.WriteLine("Friet of patat?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);

            Vraag2();
        }
        internal void Vraag2()
        {
            Console.WriteLine("Hi");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);

            Vraag3();
        }
        internal void Vraag3()
        {
            Console.WriteLine("Wie is de huidige president van Amerika?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);

            Vraag4();
        }
        internal void Vraag4()
        {
            Console.WriteLine("Wie is Daniel Larson?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);

            Vraag5();
        }
        internal void Vraag5()
        {
            Console.WriteLine("Wie is Bill Gates?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);

            Vraag6();
        }
        internal void Vraag6()
        {
            Console.WriteLine("Hello?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);

        }
        internal string Vraag7()
        {
            Console.WriteLine("Wie is Mario?");
            string antwoord = Console.ReadLine();



            return antwoord;
        }

        internal string GetRandomVraag()
        {
            int vraagIndex = rnd.Next(vragen.Length);
            return GetVraag(vraagIndex);
        }


    }

}