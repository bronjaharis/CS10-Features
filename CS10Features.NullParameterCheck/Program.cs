string? Name = null;

SayHello(Name);

void SayHello(string name) 
{
    //if (name == null)
    //    throw new ArgumentNullException("name");

    //ArgumentNullException.ThrowIfNull(name, nameof(name));

    Console.WriteLine($"Hello {name}");
}