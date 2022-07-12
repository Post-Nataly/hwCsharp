// программaпринимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine ("Введите число:");

int N = Convert.ToInt32(Console.ReadLine());

int pal = N;

int dig = pal%10;

int revers = 0;

while (pal>0)
{
    dig = pal%10;
    revers = revers*10 + dig;
    pal = pal/10;
}
if (N == revers)
{
    Console.WriteLine("Это палиндром");
}
else
Console.WriteLine("Это не палиндром");