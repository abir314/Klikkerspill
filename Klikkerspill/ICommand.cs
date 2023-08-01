namespace Klikkerspill;

public interface ICommand
{
    char Character { get;}
    void Run();
}