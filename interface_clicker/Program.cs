namespace ClickerInterface
{
    static class Program
    {
        static void Main(string[] args)
        {
            ClickerGame game = new ClickerGame();
            CommandSet cmdSet = new CommandSet(game);
            Console.Clear();
            Console.WriteLine(
                            "Kommandoer: \r\n- SPACE = klikk\r\n- K = regular upgrade\r\n- S = super upgrade\r\n- X = avslutt"
                    );
            while (true)
            {
                Console.WriteLine("Poeng: " + game.points);
                Console.WriteLine("Tast en kommando");
                char command = Console.ReadKey().KeyChar;
                cmdSet.RunCommand(command);
            }
        }
    }

    public class ClickerGame
    {
        public int points = 0;
        private int pointsPerClick = 1;
        private int pointsPerClickIncrease = 1;

        public void Click()
        {
            points += pointsPerClick;
        }

        public void RegularUpgrade()
        {
            if (points >= 10)
            {
                points -= 10;
                pointsPerClick += pointsPerClickIncrease;
            }
        }

        public void SuperUpgrade()
        {
            if (points >= 100)
            {
                points -= 100;
                pointsPerClickIncrease++;
            }
        }
    }
}
