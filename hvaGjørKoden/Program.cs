int range = 250;
int[] counts = new int[range];
string text = "something";

// Så lenge input ikke er tomt, kjør loop
while (!string.IsNullOrWhiteSpace(text))
{
		// Hent input fra bruker
    text = Console.ReadLine();
		// Gå over hver karakter i input
    foreach (var character in text ?? string.Empty)
    {
				// For hver karakter vi møter på, lagre hvor ofte vi har sett den i arrayet
        counts[(int)character]++;
    }
		// Istedenfor å hente counts.Length, så bruker vi range for å loope over counts arrayet
    for (var i = 0; i < range; i++)
    {
				// Vi vil bare printe noe hvis vi har møtt på karakteren mer enn 0 ganger
        if (counts[i] > 0)
        {
						// Print karakteren og hvor ofte vi har møtt på den
            var character = (char)i;
            Console.WriteLine(character + " - " + counts[i]);
        }
    }
}
