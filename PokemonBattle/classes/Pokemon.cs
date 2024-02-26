namespace PokemonBattle.classes;

public abstract class Pokemon
{
    public void battleCry(string name, int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            Console.WriteLine(name + " says: " + name + "!");
        }
    }
}