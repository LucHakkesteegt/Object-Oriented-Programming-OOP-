namespace PokemonBattle.classes
{
    class Trainer
    {
        public string Name { get; private set; }
        public List<Pokemon> Belt { get; private set; }

        public Trainer(string name)
        {
            Name = name;
            Belt = [];
            
            for (var i = 0; i < 2; i++)
            {
                Belt.Add(new Charmander("Charmander"));
                Belt.Add(new Squirtle("Squirtle"));
                Belt.Add(new Bulbasaur("Bulbasaur"));
            }
        }
        
        public void ThrowPokeball()
        {
            var pokemon = Belt.First();
            string pokemonName = pokemon.ToString().Split(".").Last();
            Console.WriteLine($"{Name} threw a Poke ball with a {pokemonName} inside!");
            pokemon.BattleCry(pokemonName, 1);
            Belt.Remove(pokemon);
        }
    }
}