using System;
using System.Text;
public class CharMath
{
    public static string caesarCipher(string s, int k)
    {
        StringBuilder sb = new StringBuilder();
        char[] characters = new char[] {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
        
        var upperCase = false;
        int charVal = 0;
        for(int i = 0; i < s.Length; i++) {
            if (char.IsLetter(s[i])) {
                if (char.IsUpper(s[i])) {
                    upperCase = true;
                    charVal = char.ToLower(s[i]) - 'a' + k;
                }
                else {
                    charVal = s[i] - 'a' + k;
                }

                if (charVal > characters.Length) {
                    charVal = charVal - characters.Length;
                }

                if (upperCase) {
                    sb.Append(char.ToUpper(characters[charVal]));
                    upperCase = false;
                }
                else {
                    sb.Append(characters[charVal]);
                }
            }
            else {
                sb.Append(s[i]);
            }
        }
        return sb.ToString();
    }
}