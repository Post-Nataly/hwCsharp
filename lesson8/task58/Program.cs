// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            Console.Write(mtrx[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] MultiplyMatrix(int[,] matrix,int[,] matrix1, int[,] matrix2)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = matrix1[i, j] * matrix2[i, j];
        }
    }
    return matrix;
}



int[,] arr = GetMatrix(4, 4, 0, 10);
PrintMatrix(arr);
Console.WriteLine();
int[,] array = GetMatrix(4, 4, 0, 10);
PrintMatrix(array);
Console.WriteLine();
Console.WriteLine("Произведение матриц:");
int[,] matrix = GetMatrix(4, 4, 0, 10);
PrintMatrix(MultiplyMatrix(matrix,arr,array));

