string[] array1 = new string[5] { "123", "23", "hello", "world", "res" };
string[] array2 = new string[array1.Length];


void CreateSecondArrayWithIf(string[] arr_1, string[] arr_2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (arr_1[i].Length <= 3)
        {
            arr_2[count] = arr_1[i];
            count++;
        }
    }
}