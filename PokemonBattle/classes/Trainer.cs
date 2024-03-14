namespace PokemonBattle.classes
{
    public class Trainer
    {
        public string Name { get; }
        // list must only be filled with pokeballs
        private List<Pokeball> belt;

        public Trainer(string name)
        {
            Name = name;
            belt = new List<Pokeball>();
            
            // initialize the belt with 2 of each pokemon
            InitializeBelt();
        }

        private void InitializeBelt()
        {
            const int numberOfPokeballs = 2;
            for (int i = 0; i < numberOfPokeballs; i++)
            {
                belt.Add(new Pokeball(new Charmander("Charmander"), this));
                belt.Add(new Pokeball(new Squirtle("Squirtle"), this));
                belt.Add(new Pokeball(new Bulbasaur("Bulbasaur"), this));
            }
        }

        public Pokeball ThrowPokemon(string trainerName)
        {
            // get a random pokemon from the belt with a random index
            Random random = new Random();
            int index = random.Next(belt.Count);
            Pokeball pokeball = belt[index];
            belt.RemoveAt(index);
            
            Console.WriteLine(trainerName + " throws " + pokeball.Pokemon.Name + "!");
            pokeball.Pokemon.BattleCry(pokeball.Pokemon.Name, 1);
            return pokeball;
        }

        public void RemovePokemon(Pokeball pokeball)
        {
            belt.Remove(pokeball);
        }

        public bool HasPokemon()
        {
            return belt.Count > 0;
        }
    }
}