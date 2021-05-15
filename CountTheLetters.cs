using System;
using System.Collections.Generic;

public class Kata
{
  public static Dictionary<char, int> Count(string str)
  {
    Dictionary<char, int> d = new Dictionary<char, int>();
    
    foreach(var c in str) {
      if (d.ContainsKey(c)) {
        d[c]++;
      }
      else {
        d.Add(c, 1);
      }
    }
    return d;
  }
}