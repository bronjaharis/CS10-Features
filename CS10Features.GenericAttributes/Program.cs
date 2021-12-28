Console.WriteLine("Hello, World!");


//Apply <LangVersion>preview</LangVersion> 
public class MyAttribute<T> : Attribute
{
    public T GenericType { get; set; }
}