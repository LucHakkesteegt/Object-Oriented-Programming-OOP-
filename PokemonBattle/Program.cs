using PokemonBattle.classes;

namespace PokemonBattle
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Enter a name for the first trainer: ");
                string name1 = Console.ReadLine();
                Trainer trainer1 = new Trainer(name1);
                Console.WriteLine("Enter a name for the second trainer: ");
                string name2 = Console.ReadLine();
                Trainer trainer2 = new Trainer(name2);

                Arena arena = new Arena();
                arena.StartBattle(trainer1, trainer2);

                Console.WriteLine("Quit? (y/n)");
                string quit = Console.ReadLine();
                if (quit == "y")
                {
                    break;
                }
            }
        }
    }
}