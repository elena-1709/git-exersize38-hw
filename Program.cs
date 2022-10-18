// Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным элементов
// массива

int size = new Random().Next(1, 10);
double[] array = new double[size];
double max = 0;
double min = 1;
for (int i = 0; i < size; i++)
{
    array[i] = new Random().NextDouble();
    if (max < array[i]) max = array[i];
    if (min > array[i]) min = array[i];
}
Console.Clear();
Console.WriteLine($"Случайный массив:[{String.Join(", ", array)}]\n"
+ $"Max = {max}\n"
+ $"Min = {min}\n"
+ $"Разница между max & min = {max - min}");