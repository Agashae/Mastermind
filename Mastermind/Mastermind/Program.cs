namespace Mastermind
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mastermind!");
            Console.WriteLine("Que voulez-vous faire ?");
            Console.WriteLine();
            Console.WriteLine("0. Quitter");
            Console.WriteLine("1. Voir les règles");
            Console.WriteLine("3. Jouer");

            ConsoleKey key = Console.ReadKey(true).Key;


            do
            {
                Console.Clear();   
                Console.WriteLine("Welcome to Mastermind!");
                Console.WriteLine("Que voulez-vous faire ?");
                Console.WriteLine();
                Console.WriteLine("0. Quitter");
                Console.WriteLine("1. Voir les règles");
                Console.WriteLine("3. Jouer");


                key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.Q)
                {
                    Quitter();
                }
                else if (key == ConsoleKey.R)
                {
                    AfficherRegles();
                }
                else if (key == ConsoleKey.J)
                {
                    Jouer();
                }
            } while (key != ConsoleKey.Q && key != ConsoleKey.R && key != ConsoleKey.J);


            Console.ReadLine();
        }

        static void Quitter()
        {
            Environment.Exit(0);
        }

        static void AfficherRegles()
        {
            Console.WriteLine("Règles du jeu Mastermind :");
        }

        static void Jouer()
        {
            Console.Clear();
           Console.WriteLine("Bienvenue dans le jeu Mastermind !");
            Console.WriteLine("Dans ce jeu, vous devez deviner une combinaison de couleurs secrètes.");

        }
    }
}
