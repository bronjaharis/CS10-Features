var names = new[] { "Nick", "John", "Mike", "James" };

var serialized = JsonSerializer.Serialize(names);

foreach (var name in names)
{
    Console.WriteLine(name);
}

//WriteLine("Test");