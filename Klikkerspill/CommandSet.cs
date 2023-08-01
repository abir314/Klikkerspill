namespace Klikkerspill;

public class CommandSet
{
    public ICommand[] Commands;

    public CommandSet(ClickerGame game)
    {
        Commands = new ICommand[]
        {
            new CommandX(game),
            new CommandSpace(game),
            new CommandK(game),
            new CommandS(game)
        };
    }

    public void RunCommand(char command)
    {
        var usersCommand = Commands.FirstOrDefault(c => c.Character == command);
        usersCommand?.Run();
    }
}