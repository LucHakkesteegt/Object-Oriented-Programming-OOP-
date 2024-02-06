class Pokemon:
    def __init__(self, name, health, strength, weakness):
        self.name = name
        self.all_pokemon = {name: {"health": health, "strength": strength, "weakness": weakness}}

    def getPokemon(self):
        return self.all_pokemon[self.name]

    def battleCry(self, amount):
        print(f"{self.name} battle cries {amount} times!")


print("Welcome to the Pokemon Game")
getName = input("Enter a name for charmander: ")
charmander = Pokemon(getName, 100, "fire", "water")
charmander.battleCry(10)
while True:
    newNameQuestion = input(f"Do you want to enter a new name for {getName}? y/n")
    if newNameQuestion == "n":
        break
    elif newNameQuestion == "y":
        changeName = input("Enter a new name for charmander: ")
        charmander.all_pokemon[changeName] = charmander.all_pokemon.pop(getName)
        charmander.name = changeName

    print(charmander.getPokemon())
    charmander.battleCry(10)