namespace apbd;

public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        Console.WriteLine(MaxVal(arr));
        Console.WriteLine(avg(arr));
    }

    public static int MaxVal(int[] arr)
    {
        return arr.Max();
    } 
    public static double avg(int[] arr)
    {
        double res = 0.0;
        for (int i = 0; i < arr.Length; i++)
        {
            res += arr[i];
        }
        return res/arr.Length;
    }
}
