// C# code to linearly search x in arr[]. If x
// is present then return its location, otherwise
// return -1
using System;

class GFG
{
    public static int MyMin(int[] arrx)
    {

        int minimum = arrx[0];
        int N = arrx.Length;
        for (int i = 1; i < N; i++)
        {
            if (arrx[i] <= minimum)
                minimum = arrx[i];
        }
        return minimum;

    }

    // Driver's code
    public static void Main()
    {
        int[] arr = { 5, 3, 4, 10, 40 };


        // Function call
        int result = MyMin(arr);
        Console.WriteLine("The minimum number is: " + result);
    }
}