// Создать двумерный массив:
void FillArrayRandomLetters(string[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine($"Введите {i+1} строку массива, состоящую из {array.GetLength(1)} слов/цифр:");
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
void PrintShortArray(string[,] array, int n)
{
for (int i = 0; i < array.GetLength(0); i++)
{
     Console.Write("[ ");
   for (int j = 0; j < array.GetLength(1); j++)
   {
   if (array[i,j].Length <= n)
   {
 Console.Write(array[i, j] + " ");
   }
   } 
    Console.Write("]");
        Console.WriteLine("");
}
}
string [,] matrix = new string[2,3];
 FillArrayRandomLetters(matrix);
 PrintArray(matrix);
 System.Console.WriteLine("Новый массив:");
PrintShortArray(matrix,3);
