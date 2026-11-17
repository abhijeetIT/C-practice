using System;
using System.Text;

class CreateString
{
    public static void Main(string[] args)
    {
        //valid creation
        // string name = "Abhijeet";
        // string programming = "C#";

        // //creating list using -> new
        // string name = new string("Abhijeet".ToCharArray());
        // string programming = new string("C#".ToCharArray());

        //directly using System
        // System.String name = "Abhijeet";
        
        // Console.WriteLine($"My name is {name} my favourite programming language is {programming}");

        //----------------------------------------------------------------------------------------------

        StringBuilder sb = new StringBuilder();

        sb.Append("Abhijeet");
        sb.Append("Jha");

        Console.WriteLine(sb);

  
    }
}