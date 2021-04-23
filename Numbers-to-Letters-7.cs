using System;

namespace CodeWars
{
    public class Kata
    {
        public static string Switcher(string[] x)
        {
            string res = "";
            foreach (string s in x)
            {
                int letter = int.Parse(s);
                switch (letter)
                {
                    case 27:
                        res += '!';
                        break;
                    case 28:
                        res += '?';
                        break;
                    case 29:
                        res += ' ';
                        break;
                    default:
                        res += (char)('z' - letter + 1);
                        break;
                }
            }
            return res;
        }
    }
}