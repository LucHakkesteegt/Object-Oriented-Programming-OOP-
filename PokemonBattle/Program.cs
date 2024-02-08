using PokemonBattle.classes;

namespace PokemonBattle
{
    abstract class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Enter a name for the first trainer:");
                var firstTrainerName = Console.ReadLine();
                Console.WriteLine("Enter a name for the second trainer:");
                var secondTrainerName = Console.ReadLine();
                var trainer1 = new Trainer(firstTrainerName);
                var trainer2 = new Trainer(secondTrainerName);

                while (trainer1.Belt.Count > 0 && trainer2.Belt.Count > 0)
                {
                    trainer1.ThrowPokeball();
                    trainer2.ThrowPokeball();
                }
                
                Console.WriteLine("Press any key to continue or 'q' to quit");
                var key = Console.ReadKey();
                if (key.KeyChar == 'q')
                {
                    break;
                }
            }
        }
    }
}