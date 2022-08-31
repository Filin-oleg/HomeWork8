// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();
Console.WriteLine("Введите количество строк массива ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива ");
int n = Convert.ToInt32(Console.ReadLine()); ;
void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"[{matrix[i, j]}] ");
        }
        Console.WriteLine();
    }
}
int[] SumInRows (int [,] matrix)
{
    int[] sum = new int[matrix.GetLength(0)];
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            sum[k] += matrix[k, i];
        }
    }
        return sum;
}
int MinimumRow (int[] array)
{
    int min = array[0];
    int minRow = 0;
    for(int i = 0; i < array.Length; i++)
    {
    
    
        if(array[i] < min)
        {
            minRow = i;
        }
    }
    return minRow;
}

int[,] matrix = new int[m, n];
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
int[] array = SumInRows(matrix);
int result = MinimumRow(array);
Console.WriteLine($"Наименьшая сумма элеметов содержится в {result + 1} строке массива.");