char input = '0';
int firstNum = -10;
int secondNum = -10;

Random rnd = new Random();

while (true)
{
    while (firstNum == -10 && secondNum == -10 || firstNum == secondNum)
    {
        firstNum = rnd.Next(0, 100);
        secondNum = rnd.Next(0, 100);
        Console.WriteLine($"{firstNum} or {secondNum}?");
    }

    input = Console.ReadKey().KeyChar;
		Console.WriteLine();

    if (input == '<' && firstNum < secondNum || input == '>' && firstNum > secondNum)
    {
        Console.WriteLine("Correct! Assigning new numbers...");
        firstNum = -10;
        secondNum = -10;
    }
    else
    {
        Console.WriteLine("Wrong!");
    }
}
