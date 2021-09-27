using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningTotal
{
    public static int[] RunningTotalResults(int[] xs)
    {
        int[] result = new int[xs.Length];
        int temp = result[0];
        for (int i = 0; i < xs.Length; i++)
        {
            if (i > 0)
            {
                temp = result[i - 1];
            }

            result[i] = Addition(xs[i], temp);            
        }
        return result;
    }

    public static int Addition(int x, int y)
    {
        return x + y;
    }
}

