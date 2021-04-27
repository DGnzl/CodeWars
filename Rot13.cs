using System.Text;

namespace CodeWars
{
    static class Rot
    {
        public static string Rot13(string message)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in message.ToCharArray())
            {
                if (char.IsLetter(c)){
                    char temp = char.ToLower(c);
                    if (temp + 13 > 'z') {
                        temp = (char)(((temp + 13) - 'z') + 'a' - 1);
                    }
                    else {
                        temp = (char)(temp + 13);
                    }

                    if (char.IsUpper(c)){
                        sb.Append(char.ToUpper(temp));
                    }
                    else
                    {
                        sb.Append(temp);
                    }
                }
                else {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
    }
}