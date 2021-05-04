using System.Collections.Generic;
namespace CodeWars
{
public static class UniqueSet
{
    public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
    {
        List<T> items = new List<T>(iterable);
        if (items.Count > 1)
        {
            for(int i = 1; i < items.Count; i++)
            {
                if (items[i].Equals(items[i - 1]))
                {
                    items.RemoveAt(i);
                    i -=1;
                }
            }
        }
        return items;
    }
}
}