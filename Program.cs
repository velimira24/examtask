// Создать двумерный массив:
void FillArrayRandomLetters(string[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine($"Введите в столбик {i+1} строку массива, состоящую из {array.GetLength(0)} слов");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Console.ReadLine();
        }
    }
}

// Напечатать двумерный массив:
void PrintArray(string[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
string [,] matrix = new string[3,2];
 FillArrayRandomLetters(matrix);
 PrintArray(matrix);
