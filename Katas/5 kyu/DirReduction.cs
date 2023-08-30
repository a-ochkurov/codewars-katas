public class DirReduction
{
    public static string[] dirReduc(String[] arr) { 
        bool isDel = false;
        do {
            for (int i = 0;i < arr.Length-1; i++) {
                if (AreOpposite(arr[i],arr[i+1]))
                {
                    arr[i] = null;
                    arr[i+1] = null;
                } 
            }

            if (arr.Any(s => s == null))
            {
                isDel = true;
            } else {
                isDel = false;
            }

            arr = arr.Where(s => s != null).ToArray();

        } while (isDel);

        return arr;
    }

    private static bool AreOpposite(string dir1, string dir2)
    {
        return (dir1 == "NORTH" && dir2 == "SOUTH") ||
               (dir1 == "SOUTH" && dir2 == "NORTH") ||
               (dir1 == "EAST" && dir2 == "WEST") ||
               (dir1 == "WEST" && dir2 == "EAST"); 
    }
}
