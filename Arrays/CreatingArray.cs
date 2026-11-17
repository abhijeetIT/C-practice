using System;

class CreatingArray
{
    static void Main(String[] args)
    {
        // int[] arr = {1,2,3,4,5};
        
        //gives error becouse c# have rule to give bracket just after data type
        // int nums[] = {21,21,3,4,54};

        //both gives error
        // var arr = {2,2,3,4,5};
        // var[] arr = {2,2,3,4,5};


        // Valid: The compiler looks at the numbers and infers 'int[]'
        var arr = new[] {2, 2, 3, 4, 5 }; 

       // Also valid: Explicitly stating the type with 'new int[]'
        var arr2 = new int[] { 2, 2, 3, 4, 5 }; 

        Console.Write(string.Join(",",arr));
        

    }
}