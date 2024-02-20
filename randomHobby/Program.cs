string[] hobbies = {
    "Hiking",
    "Reading",
    "Swimming",
    "Painting",
    "Running",
};

string input = "";

while (true)
{
    input = Console.ReadLine();
    if (input == "cancel" || input == null)
    {
        break;
    }
    // set first letter uppercase
    string after = input.Substring(0, 1).ToUpper() + input.Substring(1);
    string hobby = hobbies[new Random().Next(hobbies.Length)];

    Console.WriteLine(after + " likes to partake in " + hobby + "!");
}
