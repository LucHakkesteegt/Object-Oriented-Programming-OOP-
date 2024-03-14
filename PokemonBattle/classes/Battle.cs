namespace PokemonBattle.classes;

public class Battle
{
    private int _winCountP1;
    private Trainer _winner = null;
    public int Round = 0;

    public Trainer StartBattle(Trainer trainer1, Trainer trainer2)
    {
        _winCountP1 = 0;
        while (trainer1.HasPokemon() && trainer2.HasPokemon())
        {
            Pokeball pokemon1 = trainer1.ThrowPokemon(trainer1.Name);
            Pokeball pokemon2 = trainer2.ThrowPokemon(trainer2.Name);

            if (pokemon1.Pokemon.Strength == PokemonType.Fire && pokemon2.Pokemon.Weakness == PokemonType.Grass || pokemon1.Pokemon.Strength == PokemonType.Grass && pokemon2.Pokemon.Weakness == PokemonType.Water || pokemon1.Pokemon.Strength == PokemonType.Water && pokemon2.Pokemon.Weakness == PokemonType.Fire)
            {
                _winCountP1++;
                Console.WriteLine($"{pokemon1.Pokemon.Name} wins!");
                trainer2.RemovePokemon(pokemon2);
            }
            else if (pokemon2.Pokemon.Strength == PokemonType.Fire && pokemon1.Pokemon.Weakness == PokemonType.Grass || pokemon2.Pokemon.Strength == PokemonType.Grass && pokemon1.Pokemon.Weakness == PokemonType.Water || pokemon2.Pokemon.Strength == PokemonType.Water && pokemon1.Pokemon.Weakness == PokemonType.Fire)
            {
                Console.WriteLine($"{pokemon2.Pokemon.Name} wins!");
                trainer1.RemovePokemon(pokemon1);
            }
            else
            {
                Console.WriteLine("It's a tie between the pokemon!\n");
            }

            Round++;
        }
        
        switch (_winCountP1)
        {
            case > 3:
                Console.WriteLine($"{trainer1.Name} wins the battle!");
                _winner = trainer1;
                break;
            case < 3:
                Console.WriteLine($"{trainer2.Name} wins the battle!");
                _winner = trainer2;
                break;
            default:
                Console.WriteLine("It's a tie!");
                break;
        }

        return _winner;
    }
}