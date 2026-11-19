using System.Text;

class Palindrome{

    public static bool IsPalindrome(string str)
    {
        int start=0 , end = str.Length-1;

        while(start < end)
        {
            if (str[start] != str[end])
            {
                return false;
            }
            start++;
            end--;
        }

        return true;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string: ");
        string str = Console.ReadLine();

        if (IsPalindrome(str.ToLower()))
        {
            Console.WriteLine("Is palindrome");
        }
        else
        {
            Console.WriteLine("Not a palindrome");
        }
    }
}