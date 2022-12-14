string[] defaultArray = new string[6] {"one", "two", "three", "four", "five", "six"};
string[] answerArray = new string[defaultArray.Length];

GetAnswerArray(defaultArray, answerArray);
Console.Write("Default array: ");
PrintArray(defaultArray);
Console.Write("Answer array: ");
PrintArray(answerArray);

void GetAnswerArray(string[] defaultArray, string[] answerArray)
{
    int j = 0;
    for (int i = 0; i < defaultArray.Length; i++)
    {
        if (defaultArray[i].Length <= 3)
            {
                answerArray[j] = defaultArray[i];
                j++;
            }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}