namespace PokemonBattle.classes;

public class Pokeball
{
    public Pokemon Pokemon { get; }

    public Trainer Owner { get; }

    public Pokeball(Pokemon pokemon, Trainer owner)
    {
        Pokemon = pokemon;
        Owner = owner;
    }
}