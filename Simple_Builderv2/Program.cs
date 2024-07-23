using Simple_Builderv2;
using System;

class Program
{
    static void Main(string[] args)
    {
        HtmlElement root = HtmlElement
            .Create("ul")
            .AddChild("li", "hello")
            .AddChild("li", "world")
            .Build();

        Console.WriteLine(root);
    }
}
