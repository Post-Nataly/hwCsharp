Console.WriteLine("Введите цифру от 1 до 7, обозначающую день недели, чтобы узнать, является ли он выходным:");

int number = Convert.ToInt32(Console.ReadLine());

if (number > 0 && number < 8)
{
    if (number > 5 && number < 8) Console.WriteLine("да");
    
    else Console.WriteLine("нет");
}
else Console.WriteLine("Введено неверное значение");
