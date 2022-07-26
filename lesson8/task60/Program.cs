// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

int[,,] GetMatrix(int l, int m, int n, int min, int max)
{
    int[,,] matrix = new int[l, m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                    matrix[i, j, k] = new Random().Next(min, max + 1);
            }

        }
    }
    return matrix;
}


void PrintMatrix(int[,,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            for (int k = 0; k < mtrx.GetLength(2); k++)
            {
                Console.Write($"{mtrx[i, j, k]}({i},{j},{k}) ");
            }

        }
        Console.WriteLine();
    }
}


int[,,] arr = GetMatrix(2, 2, 2, 9, 99);
PrintMatrix(arr);