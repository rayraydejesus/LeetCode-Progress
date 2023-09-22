using System.Text;

public class Solution_1768 : ISolution_1768
{
    public Solution_1768() { }

    public string MergeAlternately(string word1, string word2)
    {
        if (word1.Length == 1)
            return word1 + word2;

        StringBuilder mergedWord = new StringBuilder();
        int shorterLength = (word1.Length < word2.Length) ? word1.Length : word2.Length;

        for (int i = 0; i < shorterLength; ++i)
        {
            if (i == word1.Length - 1)
            {
                mergedWord.Append("" + word1[i] + word2.Substring(i));
                break;
            }
            else if (i == word2.Length - 1)
            {
                mergedWord.Append("" + word1[i] + word2[i] + word1.Substring(i + 1));
                break;
            }
            else
                mergedWord.Append("" + word1[i] + word2[i]);
        }

        return mergedWord.ToString();
    }
}
