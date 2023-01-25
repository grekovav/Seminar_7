/* 51. Задайте двумерный массив. Найдите элементы, у которых оба
индекса четные, и замените эти элементы на их квадраты.
Найдите сумму элементов главной диагонали.  */
int GetDataFromUser(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
void printInColor(string data)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write(data);
    Console.ResetColor();
}

int[,] get2DIntArray(int colLength, int rowLength, int start, int finish)
{
    int[,] array = new int[colLength, rowLength];
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i, j] = new Random().Next(start, finish + 1);
        }
    }
    return array;
}
void print2DArray(int[,] array)
{
    Console.Write("\t");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        printInColor(j + "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printInColor(i + "\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                printInColor(array[i, j] + "\t");
            }
            else
            {
                Console.Write(array[i, j] + "\t");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] Change(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array[i, j] = (int)Math.Pow(array[i, j], 2);
            }
        }
    }
    return array;
}
int findSumDiag(int[,] array)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                result = result + array[i, j];
            }
        }
    }
    return result;
}
int n = GetDataFromUser("Введите количество строк");
int m = GetDataFromUser("Введите количество столбцов");
int[,] array = get2DIntArray(n, m, 0, 10);
print2DArray(array);
int[,] arraySquare = Change(array);
print2DArray(arraySquare);
int sum = findSumDiag(array);
Console.WriteLine($"Сумма элементов главной диагонали = {sum}");
