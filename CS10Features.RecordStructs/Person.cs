namespace CS10Features.RecordStructs;

//C# 9
public record Person(string FirstName, string LastName);

//C# 10
public readonly record struct Point(double X, double Y, double Z);

//C# 10
public record struct Product
{
    public string Name { get; init; }

    public int CategoryId { get; init; }
}