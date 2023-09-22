using Microsoft.VisualBasic;

public sealed class Problem_1768 : LeetCodeProblem
{
	public Problem_1768(
		int key = 1768,
		string title = "Merge Strings Alternately",
		string url = "https://leetcode.com/problems/merge-strings-alternately/",

		string description =
        "You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1. If a string is longer than the other, append the additional letters onto the end of the merged string." +
		"\n\nReturn the merged string." +
		"\n\n \n\nExample 1:" +
		"\n\nInput: word1 = \"abc\", word2 = \"pqr\"" +
		"\nOutput: \"apbqcr\"" +
		"\nExplanation: The merged string will be merged as so:" +
		"\nword1:  a   b   c" +
		"\nword2:    p   q   r" +
		"\nmerged: a p b q c r" +
		"\nExample 2:" +
		"\n\nInput: word1 = \"ab\", word2 = \"pqrs\"" +
		"\nOutput: \"apbqrs\"" +
		"\nExplanation: Notice that as word2 is longer, \"rs\" is appended to the end." +
		"\nword1:  a   b " +
		"\nword2:    p   q   r   s" +
		"\nmerged: a p b q   r   s" +
		"\nExample 3:" +
		"\n\nInput: word1 = \"abcd\", word2 = \"pq\"" +
		"\nOutput: \"apbqcd\"" +
		"\nExplanation: Notice that as word1 is longer, \"cd\" is appended to the end." +
		"\nword1:  a   b   c   d" +
		"\nword2:    p   q " +
		"\nmerged: a p b q c   d" +
		"\n \n\nConstraints:" +
		"\n\n1 <= word1.length, word2.length <= 100" +
		"\nword1 and word2 consist of lowercase English letters."

    ) : base(key, title, url, description){}

    protected override void retrieveInput()
    {
		while (true)
		{
			base.retrieveInput();
		}
    }

    protected override void runSolution(object input)
    {
		Input_1768 parsedInput = input as Input_1768;
		ISolution_1768 solution = new Solution_1768();
		string result = solution.MergeAlternately(parsedInput.word1, parsedInput.word2);

		printSolution(result);
    }

    protected override void printSolution(object solution)
    {
		base.printSolution();
		string result = solution as string;
		Console.WriteLine(result);
    }
}

