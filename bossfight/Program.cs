namespace BossFight
{
    class Character
    {
        private int _stamina;

        public int Health { get; set; }
        public int Strength { get; set; }
        public int Stamina
        {
            get => _stamina;
            set
            {
                _startStamina = value;
                _stamina = value;
            }
        }
        public int _startStamina;

        public Character(int health, int strength, int stamina)
        {
            Health = health;
            Strength = strength;
            Stamina = stamina;
        }

        private bool CheckStamina()
        {
            if (Stamina <= 0)
            {
                Recharge();
                return true;
            }
            return false;
        }

        public void Fight(ref Character target)
        {
            if (CheckStamina())
            {
                return;
            }
            target.Health -= Strength;
            _stamina -= 10;
        }

        public void Fight(ref Character target, int min, int max)
        {
            Random rnd = new Random();
            if (CheckStamina())
            {
                return;
            }
            target.Health -= rnd.Next(min, max);
            _stamina -= 10;
        }

        public void Recharge()
        {
            _stamina = _startStamina;
        }
    }

    static class Program
    {
        static void Main(string[] args)
        {
            Character player = new Character(100, 20, 40);
            Character boss = new Character(500, 20, 10);

            while (boss.Health > 0 && player.Health > 0)
            {
                int playerHealth = player.Health;
                int bossHealth = boss.Health;
                player.Fight(ref boss);
                Console.WriteLine($"Player hit boss with {bossHealth - boss.Health} damage, boss now has {boss.Health} health");
                boss.Fight(ref player, 0, 30);
                Console.WriteLine($"Boss hit player with {playerHealth - player.Health} damage, player now has {player.Health} health");
                Console.ReadKey();
            }

            Console.WriteLine("Game over!");
            if (boss.Health <= 0)
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Boss won!");
            }
        }
    }
}
