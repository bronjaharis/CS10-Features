using CS10Features.RecordStructs;

var product = new Product
{
    Name = "VideoGame",
    CategoryId = 1
};

//product.Name = "";
// Error CS8852  Init-only property or indexer 'Product.Name' can only be assigned in an object initializer,
// or on 'this' or 'base' in an instance constructor or an 'init' accessor.


/// <summary>
/// With-expressions
/// </summary>
//var newProduct = product with { CategoryId = 2 };

/// <summary>
/// Equality comparison
/// </summary>
//var product1 = new Product
//{
//    Name = "VideoGame",
//    CategoryId = 1
//};

//var product2 = new Product
//{
//    Name = "VideoGame",
//    CategoryId = 1
//};

//Console.WriteLine(product1.Equals(product2)); // Returns true

//Console.WriteLine(product1 == product2); // Returns true. Only allowed on record structs, not allowed on regular structs


/// <summary>
/// Printing members
/// </summary>
//var product1 = new Product
//{
//    Name = "VideoGame",
//    CategoryId = 1
//};

//Console.WriteLine(product); // Will output: Product { Name= VideoGame, CategoryId = 1 }