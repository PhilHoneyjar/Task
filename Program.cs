string[] defaultArray = new string[6] {"one", "two", "three", "four", "five", "six"};
string[] answerArray = new string[defaultArray.Length];

int j = 0;
    for (int i = 0; i < defaultArray.Length; i++)
    {
        if (defaultArray[i].Length <= 3)
            {
                answerArray[j] = defaultArray[i];
                j++;
            }
    }

Console.Write("Default array: ");

for (int i = 0; i < defaultArray.GetLength(0); i++)
    {
        Console.Write($"{defaultArray[i]} ");
    }
    Console.WriteLine();

Console.Write("Answer array: ");

for (int i = 0; i < answerArray.GetLength(0); i++)
    {
        Console.Write($"{answerArray[i]} ");
    }
    Console.WriteLine();