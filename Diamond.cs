using System;
using System.Text;
namespace CodeWars
{
   public static class Diamond
    {
        public static string Print(int n)
        {
            if (n < 1 || n % 2 == 0) return null;

            var sb = new StringBuilder();
            int spaces = (n/2);
            int stars = 1;

            while(stars <= n) {
                for (int i = 0; i < spaces; i++) {
                    sb.Append(" ");
                }
                for (int i = 0; i < stars; i++){
                    sb.Append("*");
                }
                sb.Append("\n");
                stars += 2;
                spaces -= 1;
            }
            stars -= 4;
            spaces += 2;
            while(stars >= 1) {
                for (int i = 0; i < spaces; i++) {
                    sb.Append(" ");
                }
                for (int i = 0; i < stars; i++){
                    sb.Append("*");
                }
                sb.Append("\n");
                stars -= 2;
                spaces += 1;
            }
            return sb.ToString();

            // Update to use sb.Append(char, repeatCount);
        }
    }
}