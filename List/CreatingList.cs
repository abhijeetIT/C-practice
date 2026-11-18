using System;
using System.Collections.Generic;
using System.Linq;

class CreatingList
{
    static void Main(string[] args)
    {
        // Method 1
        List<int> list1 = new List<int>();
        list1.Add(10);
        list1.Add(20);

        // Method 2
        List<int> list2 = new List<int> { 10, 20, 30 };

        // Method 3
        var list3 = new List<int> { 10, 20, 30 };

        // Method 4
        List<int> list4 = new() { 10, 20, 30 };

        // Method 5
        int[] arr = { 10, 20, 30 };
        List<int> list5 = new List<int>(arr);

        // Method 6
        List<int> list6 = arr.ToList();

        Console.WriteLine(string.Join(", ", list5));
    }
}