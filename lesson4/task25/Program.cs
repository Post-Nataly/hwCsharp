// цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

int a = 3;
int b = 5;
int degree (int result)
{
    int res = a*a;
    for (int i = 2; i < b; i++)
    {
        res = res * a ;
    }
    return res;
}
if (b<2)
{
    Console.WriteLine(a);
}
else
{
    Console.WriteLine(degree(a));
}