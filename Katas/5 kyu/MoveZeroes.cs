public class MoveZeroesClass
{
    public static int[] MoveZeroes(int[] arr)
    {
        return arr.OrderBy(x => x==0).ToArray();
    }

}
