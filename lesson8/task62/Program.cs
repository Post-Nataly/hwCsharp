// Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7


void GetMatrix(int[,] array)
{
    int start = 0;
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = start + 1;
            start++;
        }   
    }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        array[i, array.GetLength(1)-1] = start + 1;
            start++;
    }
    for (int j = 2; j >= 0; j--)
    {
        array[array.GetLength(0)-1, j] = start + 1;
            start++;
    }
    for (int i = 2; i > 0; i--)
    {
        array[i, 0] = start + 1;
            start++;
    }
    for (int j = 1; j <array.GetLength(1)-1; j++)
    {
        array[1, j] = start + 1;
            start++;
    }
    for (int j = 2; j > 0; j--)
    {
        array[array.GetLength(0)-2, j] = start + 1;
            start++;
    }
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

int[,] arr = new int[4, 4];
GetMatrix(arr);
PrintMatrix(arr);
