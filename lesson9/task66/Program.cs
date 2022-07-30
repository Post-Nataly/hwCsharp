// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

static int Akkerman(int m, int n)
{
    while( m>=0 && n>=0)
    if (m == 0)
    {
        return n + 1;
    }
    else
    if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    if (m != 0 && n != 0)
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
    return n + 1;;

}

static void Main(String[] args)
{
    Console.WriteLine($"A(m,n) = {Akkerman(2, 3)}");
}