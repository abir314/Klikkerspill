namespace Klikkerspill;

public class CommandSpace : ICommand
{
    public char Character { get; } = ' ';
    public ClickerGame Game;

    public CommandSpace(ClickerGame game)
    {
        Game = game;
    }

    public void Run()
    {
        Game.CommandSpace();
    }
}