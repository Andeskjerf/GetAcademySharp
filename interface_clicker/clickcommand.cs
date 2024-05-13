namespace ClickerInterface;

class ClickCommand : ICommand
{
    private ClickerGame clickerGame;
		public char Character { get; } = ' ';

    public ClickCommand(ClickerGame clickerGame)
    {
        this.clickerGame = clickerGame;
    }

    public void Run()
    {
        clickerGame.Click();
				Console.WriteLine($"Klikket. Poeng: {clickerGame.points}");
    }
}
