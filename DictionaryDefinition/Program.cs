// Declare new dictionary key: strings, values: strings using collection-initializer syntax
var cities = new Dictionary<string, string>()
{
    {"Poland", "Olsztyn, Danzig, Bialystok"},
    {"UK", "London, Birmingham, Manchester, Liverpool"},
    {"Australia", "Sydney, Adelaide, Katoomba, Mascot"},
    {"USA", "New York, Boston, Seattle" },
};

// Extract and combine countries into a single string
string combinedCities = "";
var keys = new List<string>();
var lowercountry = new List<string>();
foreach (var kvp in cities)
{
    keys.Add(kvp.Key);
    lowercountry.Add((kvp.Key).ToLower());
}

combinedCities = String.Join(',', keys);

// Check if given country is in the dictionary
while (true)
{
    // Ask for country name
    string? userCountry = "";
    string userUpper = "";
    Console.Write("Pick one of the following countries: {0}: ", combinedCities);

    // Trim the white spaces from the string and convert in to lowercase
    userCountry = Console.ReadLine().Trim(' ').ToLower();
    /* Now uppercase the first letter and concatenate it with the rest of the string
       or uppercase the whole string if the length is less than three*/
    if (userCountry.Length > 3)
        userUpper = char.ToUpper(userCountry[0]) + userCountry.Substring(1);
    else
        userUpper = userCountry.ToUpper();

    // Check if the country is not empty and is in the defined dictionary
    if (userCountry != "")
    {
        if (lowercountry.Contains(userCountry))
        {
            Console.WriteLine("{0} has following significant cities: {1}", userUpper, cities[userUpper]);
            break;
        }
        else
            Console.WriteLine("{0} doesn't have any major city. Try again.\n", userUpper);
    }
    else
        Console.WriteLine("No user input, try again.\n");
}
