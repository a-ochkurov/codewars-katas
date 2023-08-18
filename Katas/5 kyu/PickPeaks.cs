using System;
using System.Collections.Generic;
public class PickPeaks
{
    public static Dictionary<string, List<int>> GetPeaks(int[] arr)
    {
        var pos = new List<int>();
        var peaks = new List<int>();

        if (arr.Length > 2)
        {
            var platoValue = 0;
            var platoStartPos = -1; 
            for (int i = 1; i < arr.Length-1; i++)
            {
                if (arr[i] > arr[i-1] && arr[i] > arr[i+1])
                {
                    peaks.Add(arr[i]);
                    pos.Add(i);
                }else if (arr[i] > arr[i-1] && arr[i] == arr[i+1])
                {
                    platoValue = arr[i];
                    platoStartPos = i;
                } else if (arr[i] == arr[i-1] && arr[i] > arr[i+1] && platoStartPos>0)
                {
                    peaks.Add(platoValue);
                    pos.Add(platoStartPos);   
                }
            }
        }


        var res = new Dictionary<string, List<int>>()
        {
            ["pos"] = pos,
            ["peaks"] = peaks,
        };
        return res;
    }
}