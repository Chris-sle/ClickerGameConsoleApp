namespace ClickerGameConsoleApp;

public interface ICommand
{
    void Run();
    char Character { get; }
}