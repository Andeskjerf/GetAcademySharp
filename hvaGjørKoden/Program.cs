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

    Dictionary<char, double> percentages = new Dictionary<char, double>();
    for (var i = 0; i < range; i++)
    {
        if (counts[i] > 0)
        {
            percentages.Add((char)i, ((double)counts[i] / (double)text.Length) * 100.0);
        }
    }

    percentages = percentages.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

    foreach (KeyValuePair<char, double> kvp in percentages)
    {
        Console.WriteLine(kvp.Key + " - " + Math.Round(kvp.Value));
    }
}
