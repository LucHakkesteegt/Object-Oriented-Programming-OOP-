namespace PokemonBattle.classes;

public class Trainer
{
    public string? Name;
    private List<Pokeball> belt = [];
    
    public Trainer(string? name)
    {
        Name = name;
        for (int i = 0; i < 6; i++)
        {
            belt.Add(new Pokeball(new Charmander(name)));
        }
    }
    
    public Pokeball throwPokemon()
    {
        Pokeball pokemon = belt[0];
        belt.RemoveAt(0);
        pokemon.battleCry(Name, 10);
        return pokemon;
    }
}