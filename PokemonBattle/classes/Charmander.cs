namespace PokemonBattle.classes;

public class Charmander : Pokemon
{
    public string? Name;
    public readonly string Strength = "Fire";
    public readonly string Weakness = "Water";

    public Charmander(string? name)
    {
        Name = name;
    }

    
}