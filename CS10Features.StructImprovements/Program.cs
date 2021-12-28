using CS10Features.StructImprovements;

/// <summary>
/// Example 1
/// </summary>

var rectangle = new Rectangle(256,512);

var rectangle2 = rectangle with { Height = 120 };

Console.WriteLine(rectangle2.Width);

/// <summary>
/// Example 2
/// </summary>
var m1 = new Measurement();
Console.WriteLine($"{m1.Value}-{m1.Description}");  // output: NaN (Undefined)

var m2 = default(Measurement);
Console.WriteLine($"{m2.Value}-{m2.Description}");  // output: 0 ()