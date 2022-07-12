// программа выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.WriteLine("Введите число:");

string n = Console.ReadLine();

int index = int.Parse(n[2].ToString());

int last = int.Parse(n[n.Length-1].ToString());

if (n[2] < n[n.Length-1])

Console.WriteLine("Третьей цифры не существует");

else

Console.WriteLine(index);
