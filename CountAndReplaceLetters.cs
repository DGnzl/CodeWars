using System.Collections.Generic;
public class CountAndReplaceLetters
{
  public static string DuplicateEncode(string word)
  {
    Dictionary<char, int> d = new Dictionary<char, int>();
    
    foreach(var c in word.ToLower()) {
      if (d.ContainsKey(c)) {
        d[c]++;
      }
      else {
        d.Add(c, 1);
      }
    }
    string result = "";
    foreach(var x in word.ToLower()) {
        result += (d[x] > 1) ? ")" : "(";
    }
    return result;
  }
}