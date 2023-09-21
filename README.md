# Leetcode-Progress
<a href="https://docs.microsoft.com/en-us/dotnet/csharp/" target="_blank" rel="noreferrer"><img align="center" src="https://raw.githubusercontent.com/danielcranney/readme-generator/main/public/icons/skills/csharp-colored.svg" width="36" height="36" alt="C#" /></a>
Console app to showcase Leet Code solutions, OOP and input parsing.

**Description**
------------------
😁 Hi I'm Ray De Jesus! I have been programming professionally for over 6 years developing web and mobile applications for many clients. This is just a little console app to showcase some of my leetcode progress as I have been brushing up on data structures and algorithms. Additionally this serves as a display of my knowledge of fundamentally important techniques and principles as a software engineer. No flashy frameworks just problem solving and SOLID code.

**Some key points**
- This repo showcases leetcode solutions I have coded myself.
- This repo is used as a way to display input parsing and string manipulation.
- This repo highlights proper OOP usage with SOLID principles in mind.

</br><p align = "center">🙌🙌🙌 If you like the project feel free to make your own progess repo with the [template](https://github.com/rayraydejesus/LeetCode-CSharp-Template) I've created. 🙌🙌🙌</p>


**Contents**
------------------
| # | Title | Solution | Time | Space | Analysis |
|---| ----- | --------- | ---- | ---- | ------- |
| 1 | [Two Sum](https://leetcode.com/problems/two-sum/) | [Source](./Problems/1/Solutions/Solution_1_Hashmap.cs) | O(N) | O(N) | [README](./Problems/1/README.md) |

**Usage**
-----------
Download the repository and run in Visual Studio or by using the command.
```
  dotnet run
```

**Architecture**
-----------
</br>**<em>[Common Folder](./Common/)</em>**
- Contains an interface and abstract class to dervive Leet Code problems from.
- The "prompts" class is used to handle basic error and input prompting.
  
</br>**<em>[Problems Folder](./Problems/)</em>** 
- Stores the folders for each problem aka solution.
- Additionly there is a [Problems Index File](./Problems/ProblemsIndex.cs) where all problems are registered your problem to a switch case.
- This switch case is used to create a constant hash map based on how c# compiles code. This also prevents creating every problem as an object in memory at application startup... Think of it as <em>lazy loading</em> our problems.

</br>**<em>[Problems/1 Breakdown](./Problems/1/)</em>**
- The [Problem_1 File](./Problems/1/Problem_1.cs) showcases our leetcode problem derived from the "LeetCodeProblem" abstact class. This is where our input parsing happens.
- Within [/Common](./Problems/1/Common/) we have an interface for all our solutions. This allows us to include multiple solution variants while maintaining a common interface for us to connect to. Also within this folder is an object for us to cast our problem input into.
- Within [/Solutions](./Problems/1/Solutions/) as stated above, we can provide the many different solution variants by utilizing our solution interface.

</br><strong>CHEERS! 🍻</strong>
-------
