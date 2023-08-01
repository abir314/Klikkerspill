namespace Klikkerspill;

public class CommandK : ICommand
{
    public char Character { get; } = 'K';
    public ClickerGame Game;

    public CommandK (ClickerGame game)
    {
        Game = game;
    }

    public void Run()
    {
        Game.CommandK();
    }
}