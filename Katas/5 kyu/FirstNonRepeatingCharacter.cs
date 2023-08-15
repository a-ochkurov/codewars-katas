using System.Linq;

public class Kata
{
  public static string FirstNonRepeatingLetter(string s)
  {
    var sub = s.ToLower();
    for (int i = 0; i < s.Length; i++)
    {
      if (!sub.Select((c, index) => new    
      {    
        StringChar = c,    
        Position = index    
        }).Where(item => item.StringChar.Equals(sub[i]) && item.Position != i).Any())
      {
        return s[i].ToString();
      }
    }

    return string.Empty;
  }
}