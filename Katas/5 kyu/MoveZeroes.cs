public class MoveZeroesClass
{
    public static int[] MoveZeroes(int[] arr)
    {
        var nonZero = new List<int>();
        var zeroList = new List<int>();
        foreach (int i in arr)
        {
            if (i == 0) {
                zeroList.Add(0);
            } else {
                nonZero.Add(i);
            } 
        }
        var res = new List<int>();
        res.AddRange(nonZero);
        res.AddRange(zeroList);
        
        return res.ToArray();
    }

}
