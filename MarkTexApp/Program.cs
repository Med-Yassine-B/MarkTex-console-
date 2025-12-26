using System;

class Program
{
    static void Main()
    {
        string myText = Console.ReadLine()??"empty";

        
        //testing
        string result = MarkTexRenderer.Convert(myText, false);
        
        Console.WriteLine("Original: " + myText);
        Console.WriteLine("Rendered: " + result);
    }
}
