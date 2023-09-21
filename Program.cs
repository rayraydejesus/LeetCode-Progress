
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Leet Code console app!");

        string input = "";
        int key = -1;
        
        while(true)
        {
            Console.WriteLine("\nPlease input the number of the question you'd like to see.");
            input = Console.ReadLine();

            if(int.TryParse(input, out key))
            {
                Console.Clear();
                ILeetCodeProblem problem = ProblemsIndex.retrieveProblem(key);

                if (problem == null)
                    Console.WriteLine("\nProblem " + key + " is currently unavailible.");
                else
                    problem.runProblem();
            }
            else
            {
                Console.WriteLine("\nInvalid response.");
            }


            if (!Prompts.oneMoreTime())
                break;
        }

        Console.WriteLine("\nGoodbye!");
    }
}
