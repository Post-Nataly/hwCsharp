// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

static int Summ(int M, int N)
{
    if (M > 0 && M < N)
    {
        return M + Summ(M + 1, N);
    }
    else
    if (M == N)
    {
        return M;
    }
    else
    return 0;
}

Console.Write($"Сумма натуральных элементов = {Summ(1, 15)}");