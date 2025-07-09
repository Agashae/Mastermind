using System.Runtime.CompilerServices;

namespace Mastermind
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Mastermind!");
            Console.WriteLine("Que voulez-vous faire ?");
            Console.WriteLine();
            Console.WriteLine("Q. Quitter");
            Console.WriteLine("R. Voir les règles");
            Console.WriteLine("J. Jouer");
            ConsoleKey key = Console.ReadKey(true).Key;


            do
            {
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
            Console.Clear();
            Console.WriteLine("Règles du jeu Mastermind :");
            Console.WriteLine();
            Console.WriteLine("Voilà les différentes couleurs");
            Console.WriteLine();


            int MargeHorizontale = 1;
            int MargeVerticale = 5;


            Console.SetCursorPosition(MargeHorizontale, MargeVerticale);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("█ rouge");
            Console.ResetColor();
            Console.SetCursorPosition(MargeHorizontale, MargeVerticale + 2);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("█ vert");
            Console.ResetColor();
            Console.SetCursorPosition(MargeHorizontale, MargeVerticale + 4);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("█ bleu");
            Console.ResetColor();
            Console.SetCursorPosition(MargeHorizontale, MargeVerticale + 6);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("█ jaune");
            Console.ResetColor();
            Console.SetCursorPosition(MargeHorizontale, MargeVerticale + 8);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("█ cyan");
            Console.ResetColor();

            Console.SetCursorPosition(MargeHorizontale + 20, MargeVerticale);
            Console.WriteLine("Voici un exemple");
            Map(MargeHorizontale, MargeVerticale);

            Console.SetCursorPosition(MargeHorizontale + 21, MargeVerticale + 2);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("█");

            Console.SetCursorPosition(MargeHorizontale + 23, MargeVerticale + 2);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("█");

            Console.SetCursorPosition(MargeHorizontale + 25, MargeVerticale + 2);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("█");

            Console.SetCursorPosition(MargeHorizontale + 27, MargeVerticale + 2);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("█");



        }

        static void Jouer()
        {
            Console.Clear();
            Console.WriteLine("Bienvenue dans le jeu Mastermind !");
            Console.WriteLine("Dans ce jeu, vous devez deviner une combinaison de couleurs secrètes.");



        }

        static void Map(int MargeHorizontale, int MargeVerticale)
        {
                string PremiereLigne = "┌─┬─┬─┬─┐";
                string DeuxiemeLigne = "│ │ │ │ │";
               string TroisiemeLigne = "└─┴─┴─┴─┘";

            Console.SetCursorPosition(MargeHorizontale + 20, MargeVerticale + 1);
            Console.WriteLine(PremiereLigne);
            Console.SetCursorPosition(MargeHorizontale + 20, MargeVerticale + 2);
            Console.WriteLine(DeuxiemeLigne);
            Console.SetCursorPosition(MargeHorizontale + 20, MargeVerticale + 3);
            Console.WriteLine(TroisiemeLigne);
        }
    }
}
