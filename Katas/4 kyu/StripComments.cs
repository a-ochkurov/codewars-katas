public class StripCommentsSolution
{
    public static string StripComments(string input, string[] commentSymbols)
    {
        string[] lines = input.Split('\n');
        for (int i = 0; i < lines.Length; i++)
        {
            foreach (string marker in commentSymbols)
            {
                int index = lines[i].IndexOf(marker);
                if (index != -1)
                {
                    lines[i] = lines[i].Substring(0, index);
                }
            }
            lines[i] = lines[i].TrimEnd();
        }
        return string.Join("\n", lines);
    }
}