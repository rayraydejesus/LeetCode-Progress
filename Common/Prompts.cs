using System;

public static class Prompts
{
	public static bool oneMoreTime(string text = "\nWould you like to see another problem?")
	{
        Console.WriteLine(text +" (Y/N)");
        string input = Console.ReadLine().ToLower();

        if (input.Length < 1)
            return false;
        else if (input[0] == 'y')
            return true;
        else
            return false;
    }

    public static bool anotherSolution()
    {
        return oneMoreTime("\n\nWould you like to try another solution?");
    }

    public static bool invalidInput()
    {
        Console.WriteLine("\nInvalid input.");
        return anotherSolution();
    }
}


