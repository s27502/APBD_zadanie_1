namespace apbd;

public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        Console.WriteLine(MaxVal(arr));
    }

    public static int MaxVal(int[] arr)
    {
        return arr.Max();
    } 
}