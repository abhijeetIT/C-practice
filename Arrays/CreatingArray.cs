using System;


using System;

class CreatingArray
{
    static void Main(string[] args)
    {
        // Method 1: Direct initialization
        int[] arr = { 1, 2, 3, 4, 5 };

        // Method 2: Using var with implicit array creation
        var nums = new[] { 2, 2, 3, 4, 5 };

        // Method 3: Using var with explicit array type
        var arr2 = new int[] { 2, 2, 3, 4, 5 };

        Console.WriteLine(string.Join(", ", arr));
        Console.WriteLine(string.Join(", ", nums));
        Console.WriteLine(string.Join(", ", arr2));
    }
}
