string[] array_1 = new string[5] { "12355", "235463", "hello", "world", "res" };
string[] array_2 = new string[array_1.Length];


void CreateSecondArrayWithIf(string[] arr_1, string[] arr_2)
{
    int count = 0;
    for (int i = 0; i < arr_1.Length; i++)
    {
        if (arr_1[i].Length <= 3)
        {
            arr_2[count] = arr_1[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
    Console.WriteLine();
}

CreateSecondArrayWithIf(array_1, array_2);
PrintArray(array_2);