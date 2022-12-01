// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
using static System.Console;

double[] FillArray(int size)
{
    double[] array = new double[size];
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 100) + new Random().NextDouble();
    return array;
}
double MaxNumber (double[] array)
{
    double max = array[0];
    for(int j = 1; j < array.Length; j++)
    {
        if(array[j] > max)
            max = array[j];
    }
    return max;
}
double MinNumber (double[] array)
{
    double min = array[0];
    for(int y = 1; y < array.Length; y++)
    {
        if(array[y] < min)
            min = array[y];
    }
    return min;
}
WriteLine("enter size of array: ");
int size = int.Parse(ReadLine());
double[] array = FillArray(size);
double max = MaxNumber (array);
double min = MinNumber(array);
WriteLine(String.Join(", ", array));
WriteLine($"the difference between the maximum and minimum array elements = {max-min:F3}");
