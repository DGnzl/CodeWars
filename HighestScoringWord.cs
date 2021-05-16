public class HighestScoringWord
{
    public static string High(string s)
    {
        //Split string into array by spaces
        string[] words = s.Split(' ');
        int winnerIndex = 0, winnerCount = 0, runningCount;
        //Iterate through words array
        for (int i = 0; i < words.Length; i++)
        {
            //Reset running count for each word
            runningCount = 0;
            //Iterate through all the characters in each word
            foreach (char c in words[i])
            {
                //Get the character value for each character and normalize ('a' + 1)
                runningCount += c - 'a' + 1;
            }
            //Check and see if current word is the winner and update winner info
            if (runningCount > winnerCount)
            {
                winnerCount = runningCount;
                winnerIndex = i;
            }
        }
        //Return the index of the winning word
        return words[winnerIndex];
    }
}