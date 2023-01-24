/* 46. Задайте двумерный массив m x n, заполненный случайными
целыми (вещественными) числами */
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

double[,] get2DDoubleArray(int colLength, int rowLength, int start, int finish)
{
    double[,] array = new double[colLength, rowLength];
    //int divider = 100;
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            //array[i, j] = new Random().Next(start * divider, (finish + 1) * divider) / (divider + 0.0);
            array[i, j] = new Random().Next(start, finish + 1) + Math.Round(new Random().NextDouble(), 2);
        }
    }
    return array;
}
void print2DArray(double[,] array)
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
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int n = GetDataFromUser("Введите количество строк");
int m = GetDataFromUser("Введите количество столбцов");
double[,] array = get2DDoubleArray(n, m, 0, 1000);
print2DArray(array);