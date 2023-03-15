
using System;

class GFG
{
    public static int MyMax(int[] arrx)
    {

        int maximum = arrx[0];
        int N = arrx.Length;
        for (int i = 1; i < N; i++)
        {
            if (arrx[i] >= maximum)
                maximum = arrx[i];
        }
        return maximum;

    }

    // Driver's code
    public static void Main()
    {
        int[] arr = { 5, 3, 4, 10, 40 };


        // Function call
        int result = MyMax(arr);
        Console.WriteLine("The maximum number is: " + result);
    }
}