string[] options = {
        "Rotate Text",
        "Change Word"
};

string RotateText(string input)
{
    string result = "";
    for (int i = input.Length - 1; i >= 0; i--)
    {
        result += input[i];
    }
    return result;
}

string ChangeWord(string input)
{
    string result = "";
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == 'e')
        {
            result += 'a';
        }
        else
        {
            result += input[i];
        }
    }
    return result;
}

while (true)
{
    for (int i = 0; i < options.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {options[i]}");
    }

    var choice = Console.ReadKey().KeyChar;
		Console.WriteLine();
		Console.Write("Input: ");
    string input = Console.ReadLine();
    if (input == null)
    {
        Console.WriteLine("Input is null!");
				continue;
    }

    switch (choice)
    {
        case '1':
            Console.WriteLine(RotateText(input));
            break;
        case '2':
            Console.WriteLine(ChangeWord(input));
            break;
    }
}
