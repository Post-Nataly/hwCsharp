// программа, принимающая на вход трехзначное число, и выдающая на выходе вторую цифру этого числа

Console.WriteLine("Введите трехзначное число:");

string num = Console.ReadLine();

int n = int.Parse(num);

if (n > 99 && n < 1000)
{
    int answer = n % 100 / 10;
    Console.WriteLine(answer);
}
else
Console.WriteLine("Введено неверное число");
