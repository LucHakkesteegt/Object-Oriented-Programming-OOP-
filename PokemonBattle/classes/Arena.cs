namespace PokemonBattle.classes;

public class Arena
{
    static int battleCount = 0;
    static int roundCount = 0;

    public Trainer StartBattle(Trainer trainer1, Trainer trainer2)
    {
        Battle battle = new Battle();
        Trainer winner = battle.StartBattle(trainer1, trainer2);
        battleCount++;
        roundCount = battle.Round;
        Console.WriteLine("Battle count: " + battleCount);
        Console.WriteLine("Round count: " + roundCount);
        return winner;
    }
}