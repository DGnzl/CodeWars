using System;
public static class Masking
{
  // return masked string
  public static string Maskify(string cc)
  {
      int startingIndex = Math.Max(cc.Length - 4, 0);
      return new string('#', startingIndex) + cc.Substring(startingIndex);
  }
}

