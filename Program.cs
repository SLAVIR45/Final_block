Console.Clear();

void FinalWork()
{
    string[] array1 = new string[5] {"33", "work", "7689", "vpn", "145"};
    string[] array2 = new string[array1.Length];

    SamplingFromAnArray(array1, array2);
    PrintArray(array2);
}   



void SamplingFromAnArray(string[] array1, string[] array2)

{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}



FinalWork();