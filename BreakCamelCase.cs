public class BreakCamelCaseClass
{
    public static string BreakCamelCase(string str)
    {
        string ans = "";
        foreach (char c in str)
        {
            ans += (char.IsUpper(c)) ? $" {c}" : $"{c}";
        }
        return ans;
    }
}