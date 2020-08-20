using System;

class Solution
{
   public static void Main()
   {
        int[] arr = { 3, 8, 9, 7, 6 };
        int K = 3;
        Console.WriteLine (solution(arr,K));
    
   }
    public static int[] solution(int[] arr, int K)
    {
        //have an edge case if arr.Length is less than 1 return 0
        //initialize new int array
        //traverse array 
        //if i+K is less than arr length index of new arr is i+K
        //else new arr index is (i+K)% K
        if (arr.Length <= 1) return arr;
        int[] newArray = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            if (i + K >= arr.Length)
            {
                newArray[(i + K) % arr.Length] = arr[i];
            }
            else
            {
                newArray[i + K] = arr[i];
            }
        }
        return new int[arr.Length];
    }
}
