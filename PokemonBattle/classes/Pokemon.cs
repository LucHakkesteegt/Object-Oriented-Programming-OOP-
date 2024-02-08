namespace PokemonBattle.classes;

public abstract class Pokemon
{
    public int Health = 100;
    public void BattleCry(string name, int amountOfCries = 1)
    {
        for (var i = 0; i < amountOfCries; i++)
        {
            Console.WriteLine(name + "!");
        }
    }
}