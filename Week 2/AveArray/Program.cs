

class GFG
{
    public static int Average(int[] arrx)
    {

        int sum = 0;
        int N = arrx.Length;
        for (int i = 0; i < N; i++)
        {
            sum += arrx[i];
        }
        int average = sum / N;
        return average;

    }

    // Driver's code
    public static void Main()
    {
        int[] arr = { 5, 25, 4, 10, 40 };


        // Function call
        int result = Average(arr);
        Console.WriteLine("The average number is: " + result);
    }
}