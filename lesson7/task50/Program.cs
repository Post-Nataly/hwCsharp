// Программа на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],2} ");
        }
        Console.WriteLine();
    }
}

int[,] array = GetMatrix(4, 3, 1, 10);

PrintMatrix(array);

Console.WriteLine("Введите номер строки: ");
int strng = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите номер столбца: ");
int column = int.Parse(Console.ReadLine()!);

int elem = 0;

if (strng>array.GetLength(0) || column>array.GetLength(1))
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    elem = array[strng-1,column-1];
    Console.WriteLine($"Элемент: {elem}");
}
