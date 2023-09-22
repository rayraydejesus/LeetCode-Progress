public abstract class LeetCodeProblem : ILeetCodeProblem
{
	protected readonly int key;
	protected readonly string title;
	protected readonly string url;
	protected readonly string description;

	public LeetCodeProblem(int key, string title, string url, string description)
	{
		this.key = key;
		this.title = title;
		this.url = url;
		this.description = description;
	}

	public virtual void runProblem()
	{
		this.printProblem();
		this.retrieveInput();
	}

	public virtual void printProblem()
	{
		Console.WriteLine(this.key + ". " + this.title);
		Console.WriteLine(this.description);
	}

	protected virtual void retrieveInput()
	{
        Console.WriteLine("\nPlease enter the properly formatted input. Use the examples as a guide.");
    }

    // NOTE: Boxing and unboxing for simplicity sake
    protected abstract void runSolution(object input);
	protected virtual void printSolution()
	{
        Console.WriteLine("\nSolution:");
    }
	protected abstract void printSolution(object solution);
}


