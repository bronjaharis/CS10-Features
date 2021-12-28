/// <summary>
/// Example 1
/// </summary>
/// 

Func<string> helloWorld = () => "Hello world"; // Old way

//var helloWorld = () => "Hello world"; //C# 10

Console.WriteLine(helloWorld());


/// <summary>
/// Example 2
/// </summary>
/// 

Func<string?> text = () => null; // Old way

//var text = string? () => null; //C# 10


/// <summary>
/// Example 3
/// </summary>
/// 

var foo = () => 1;        // foo is type Func<Int32>
var bar = () => (long)1; // bar is type Func<Int64>

