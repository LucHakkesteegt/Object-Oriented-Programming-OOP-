using PokemonBattle.classes;

namespace PokemonBattle
{
    abstract class Program
    {
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Enter a name for the first trainer: ");
                string? name1 = Console.ReadLine();
                Trainer trainer1 = new Trainer(name1);
                Console.WriteLine("Enter a name for the second trainer: ");
                string? name2 = Console.ReadLine();
                Trainer trainer2 = new Trainer(name2);
                
                for (int i = 0; i < 6; i++)
                {
                    trainer1.throwPokemon().battleCry(trainer2.Name, 10);
                    trainer2.throwPokemon().battleCry(trainer1.Name, 10);
                }
                
                Console.WriteLine("Quit? (y/n)");
                string? quit = Console.ReadLine();
                if (quit == "y")
                {
                    break;
                }
            }
        }
    }
}