Console.WriteLine("Guess the number!");
Console.WriteLine("Guess a number between 1 and 100");
Random rnd = new Random();

int number = rnd.Next(1, 101);
int guess = 0;

while (true)
{
    guess = int.Parse(Console.ReadLine());
    if (guess < 0 || guess > 100)
    {
        Console.WriteLine("Please enter a number between 1 and 100");
        continue;
    }

		if (guess < number) {
			Console.WriteLine("Too low!");
		} else if (guess > number) {
			Console.WriteLine("Too high!");
		}

    if (guess == number)
    {
        Console.WriteLine("Correct!\nPlay again? (y/n)");
        string answer = Console.ReadLine();
        if (answer == "y")
        {
            number = rnd.Next(1, 101);
        }
        else
        {
            break;
        }
    }
}
