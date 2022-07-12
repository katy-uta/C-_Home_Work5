/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

double[] GetArray(int dimension)
{
    double[] arr = new double[dimension];
    Random randomizer = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = randomizer.Next(1, 100);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}


double GetMax(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
        Console.WriteLine($"{max} {i}");
    }
    return max;
}

double GetMin(double[] arr)
{
    double min = arr[0];
    for (int j = 1; j < arr.Length; j++)
    {
        if (arr[j] < min)
            min = arr[j];
        Console.WriteLine($"{min} {j}");
    }
    return min;
}

double GetDiffMinMax(double maxarr, double minarr)
{
    double diff = 0;
    diff = maxarr - minarr;
    return diff;
}

Console.WriteLine("Введите размерность массива:");
int dimension = int.Parse(Console.ReadLine());
double[] array = GetArray(dimension);
PrintArray(array);
Console.WriteLine();
double maxarr = GetMax(array);
Console.WriteLine($"Максимум массива = {maxarr}");
double minarr = GetMin(array);
Console.WriteLine($"Минимум массива = {minarr}");
double diffMinMax = GetDiffMinMax(maxarr, minarr);
Console.WriteLine($"Разница между максимумом и минимумом массива = {diffMinMax}");




