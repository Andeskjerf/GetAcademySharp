int range = 250;
int[] counts = new int[range];
string text = "something";

// Så lenge input ikke er tomt, kjør loop
while (!string.IsNullOrWhiteSpace(text))
{
    // Hent input fra bruker
    text = Console.ReadLine();
    // Gå over hver karakter i input
    foreach (char character in text ?? string.Empty)
    {
        // For hver karakter vi møter på, lagre hvor ofte vi har sett den i arrayet
        counts[(int)Char.ToUpper(character)]++;
    }
    int[] percentages = new int[range];
    int count = 0;
    for (var i = 0; i < range; i++)
    {
        if (counts[i] > 0)
        {
            percentages[i] = counts[i];
            count += counts[i];
        }
    }

    for (int i = 0; i < range; i++)
    {
        if (percentages[i] > 0)
        {
            double percentage = ((double)percentages[i] / (double)count) * 100.0;
            char character = (char)i;
            Console.WriteLine(character + " - " + Math.Round(percentage));
        }
    }
}
