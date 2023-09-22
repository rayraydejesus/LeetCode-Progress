using System;

public class Solution_1768 : ISolution_1768
{
	public Solution_1768(){}

    public string MergeAlternately(string word1, string word2)
    {
        if (word1.Length == 1)
            return word1 + word2;

        string mergedWord = "";
        int longerLength = (word1.Length > word2.Length) ? word1.Length : word2.Length;

        for (int i = 0; i < longerLength; ++i)
        {
            if (i < word1.Length)
                mergedWord = mergedWord + word1[i];

            if (i < word2.Length)
                mergedWord = mergedWord + word2[i];
        }

        return mergedWord;
    }
}

