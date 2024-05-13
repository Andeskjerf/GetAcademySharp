namespace ClickerInterface;

public class ExitCommand : ICommand
{
		public char Character { get; } = 'X';

    public void Run()
    {
        System.Environment.Exit(0);
    }
}
