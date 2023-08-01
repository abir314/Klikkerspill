namespace Klikkerspill;

public class CommandS : ICommand
{
    public char Character { get; } = 'S';
    public ClickerGame Game;

    public CommandS(ClickerGame game)
    {
        Game = game;
    }

    public void Run()
    {
        Game.CommandS();
    }
}