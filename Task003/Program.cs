// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();
Console.WriteLine("Введите количество строк первого и второго массива ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первого и второго массива ");
int n = Convert.ToInt32(Console.ReadLine());
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

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
    {       
        int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
 
        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {
                matrixC[i, j] = 0;
 
                for (int k = 0; k < matrixA.GetLength(1); k++)
                {
                    matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }
        return matrixC;
}


int[,] matrixA = new int[m, n];
FillMatrix(matrixA);
PrintMatrix(matrixA);
// int[,] matrixA = { // ДЛЯ ПРОВЕРКИ!!
// {2, 4},
// {3, 2}
// };
Console.WriteLine();
int[,] matrixB = new int[m, n];
FillMatrix(matrixB);
PrintMatrix(matrixB);
// int[,] matrixB = {   // ДЛЯ ПРОВЕРКИ!
// {3, 4},
// {3, 3}
// };
Console.WriteLine();
int[,] matrixResult = MatrixMultiplication(matrixA, matrixB);
PrintMatrix(matrixResult);