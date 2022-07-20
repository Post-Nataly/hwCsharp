// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19


int[] array = new int[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,100);
}
 
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)
    sum += array[i];
}

Console.WriteLine(string.Join (",", array));

Console.WriteLine(sum);