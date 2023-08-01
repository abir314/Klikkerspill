namespace Klikkerspill;

public class CommandX : ICommand
{
    public char Character { get; } = 'X';
    public ClickerGame Game;

    public CommandX(ClickerGame game)
    {
        Game = game;
    }

    public void Run()
    {
       Game.CommandX(); 
    }
}