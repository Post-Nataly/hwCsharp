// цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

int a = 2;
int b = 4;
int degree (int result)
{
    int res = a*a;
    for (int i = 2; i < b; i++)
    {
        res = res * a ;
    }
    return res;
}

Console.WriteLine(degree(a));
