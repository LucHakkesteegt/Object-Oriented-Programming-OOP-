namespace PokemonBattle.classes;

public enum PokemonType
{
    Fire,
    Grass,
    Water
}

public abstract class Pokemon
{
    public string Name { get; }
    public PokemonType Strength { get; }
    public PokemonType Weakness { get; }

    protected Pokemon(string name, PokemonType strength, PokemonType weakness)
    {
        Name = name;
        Strength = strength;
        Weakness = weakness;
    }

    public void BattleCry(string name, int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            Console.WriteLine($"{name} says: {name}!");
        }
    }
}
