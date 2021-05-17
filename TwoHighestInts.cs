public class TwoHighestInts
{
  public static int LargestPairSum(int[] numbers)
  {
      var list = new System.Collections.Generic.List<int>(numbers);
      list.Sort();
      return list[list.Count - 2] + list[list.Count - 2];
  }
}