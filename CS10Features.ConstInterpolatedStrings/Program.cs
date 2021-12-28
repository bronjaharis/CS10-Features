Console.WriteLine("Hello, World!");

//Current implementation

public class CurrentImpelentation
{
    public const string Greeting = "Hello ";
    public const string Title = "Ms. ";
    public const string LastName = "Keating";

    public const string Salutation = Greeting + ", " + Title + LastName + "!";
}


[Obsolete($"Don't use me. Instead, use {nameof(NewImplementation)}.")]
public class NewImplementation
{
    public const string Greeting = "Hello ";
    public const string Title = "Ms. ";
    public const string LastName = "Keating";

    //Combine $ + const strings
    public const string Salutation = $"{Greeting}, {Title}{LastName}!";
}