class Pokeball:
    def __init__(self, name):
        self.name = name
        self.pokemon = []

    def catchPokemon(self, pokemon):
        self.pokemon.append(pokemon)

    def releasePokemon(self, pokemon):
        self.pokemon.remove(pokemon)


class Trainer:
    def __init__(self, name):
        self.name = name
        self.belt = ["Charmander", "Charmander", "Charmander", "Charmander", "Charmander", "Charmander"]
        if len(self.belt) > 6:
            raise Exception("You can't have more than 6 pokemon in your belt")

    def throwPokeball(self, pokemon):
        self.belt.remove(pokemon)

    def returnPokeball(self, pokemon):
        self.belt.append(pokemon)


input('Press any key to begin')
nameFirstTrainer = input('Enter the name of the first trainer: ')
nameSecondTrainer = input('Enter the name of the second trainer: ')
firstTrainer = Trainer(nameFirstTrainer)
firstTrainer.throwPokeball("Charmander")

