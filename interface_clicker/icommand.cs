namespace ClickerInterface;

interface ICommand
{
	void Run();
	char Character { get; }
}
