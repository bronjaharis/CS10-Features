using CS10Features.ExtendedPropertyPatterns;

/// <summary>
/// Example 1
/// </summary>
/// 

var rectangleInside = new Rectangle(100, 100);

var rectangle = new Rectangle(200, 300, rectangleInside);

//if(rectangle is { rectangle: { Height: > 100} }) //old way

if (rectangle is { rectangle.Height: > 100 })
    Console.WriteLine("It's bigger!");