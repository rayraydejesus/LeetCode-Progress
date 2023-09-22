public static class ProblemsIndex
{
	public static ILeetCodeProblem retrieveProblem(int key)
	{
		// NOTE: Use of switch case is to create a constant hash map without creating an object for every solution i.e. lazy loading
		switch(key)
		{
			case 1:
				return new Problem_1();
			default:
				return null;
		}
	}
}

