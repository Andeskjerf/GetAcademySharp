namespace ClickerInterface;

class RegularUpgradeCommand : ICommand
{
    private ClickerGame clickerGame;
		public char Character { get; } = 'K';

    public RegularUpgradeCommand(ClickerGame clickerGame)
    {
        this.clickerGame = clickerGame;
    }

    public void Run()
    {
        clickerGame.RegularUpgrade();
    }
}
