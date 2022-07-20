// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,99);
}

double max = double.MinValue;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    max = array[i];
}

double min = double.MaxValue;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
    min = array[i];
}

double result = max - min;

Console.WriteLine(string.Join (",", array));

Console.WriteLine($"Максимальное число {max} - минимальное {min} = разница {result}");