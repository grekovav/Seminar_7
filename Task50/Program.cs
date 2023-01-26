/* 50. Напишите программу, которая на вход принимает позиции
элемента в двумерном массиве, и возвращает значение этого
элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет   */

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

void availabilityCheck(int[,] array, int n, int m, int a)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (a > array.GetLength(0) && a > array.GetLength(1))
            {
                Console.WriteLine("Такого элемента нет");
            }
            else
            {
                Console.WriteLine($"Значение элемента {n} строки и {m} столбца равно {array[n-1, m-1]}");
            }
            break;
        }
        break;
    }
}
int n = GetDataFromUser("Введите номер строки от 0 до 2");
int m = GetDataFromUser("Введите номер столбца от 0 до 3");
int a = GetDataFromUser("Введите искомое число");
int[,] array = get2DIntArray(3, 4, 0, 9);
print2DArray(array);
availabilityCheck(array, n, m, a);
