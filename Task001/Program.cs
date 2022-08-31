// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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
void RaplaceMaxToMin (int [,] matrix)
{
    
    for (int k = 0; k < matrix.GetLength(0); k++)
        for (int i = matrix.GetLength(1) - 1; i >= 0; i--)
        {
            for (int j = i - 1; j >= 0; j--)
            {
            if (matrix[k, i] >= matrix[k, j])
            {
                int temp;
                temp = matrix[k, i];
                matrix[k, i] = matrix[k, j];
                matrix[k, j] = temp;
            }
            }
        }
    }

int[,] matrix = new int[m, n];
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
RaplaceMaxToMin(matrix);
PrintMatrix(matrix);