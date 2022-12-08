string[] array = { "1234", "15", "-2", "comp" };

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}
PrintArray(array);

void SortArray(string[] Array)
{
    Console.WriteLine("Новый массив:");
    string[] newArray = new string[Array.Length];
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= 3)
        {
            newArray[i] = array[i];
            Console.WriteLine(newArray[i]);
        }
    }
}
SortArray(array);
Console.ReadLine();