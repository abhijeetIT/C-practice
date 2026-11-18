
class Program
{

    public static void Reverse(int[] arr)
    {
        if(arr.Length <= 1 )
        {
            return;
        }

        int start = 0,end = arr.Length-1;

        while(start < end)
        {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;

            start++;
            end--;
        }

    }
    static void Main(string[] args)
    {
        int[] arr = {1,2,3,4,5,6};

        Reverse(arr);
        Console.WriteLine(string.Join(", ",arr));
    }
}