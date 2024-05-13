namespace ClickerInterface;

class SuperUpgradeCommand : ICommand
{
    private ClickerGame clickerGame;
		public char Character { get; } = 'S';

    public SuperUpgradeCommand(ClickerGame clickerGame)
    {
        this.clickerGame = clickerGame;
    }

    public void Run()
    {
        clickerGame.SuperUpgrade();
    }
}
