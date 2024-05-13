namespace ClickerInterface;

public class CommandSet
{
    private ICommand[] commands = new ICommand[4];

    public CommandSet(ClickerGame game)
    {
				// why doesn't this work?
        // commands.Append(new ClickCommand(game));
        // commands.Append(new RegularUpgradeCommand(game));
        // commands.Append(new SuperUpgradeCommand(game));
        // commands.Append(new ExitCommand());
				// when this does?
				commands[0] = new ClickCommand(game);
				commands[1] = new RegularUpgradeCommand(game);
				commands[2] = new SuperUpgradeCommand(game);
				commands[3] = new ExitCommand();
    }

    public void RunCommand(char command)
    {
        foreach (ICommand cmd in commands)
        {
            if (cmd.Character == command)
            {
                cmd.Run();
            }
        }
    }
}
