// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
using static System.Console;

int[] FillArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 100);
    return array;
}
int SumNumbersOddIndex(int[] array)
{
    int sum = 0;
    for(int j = 1; j < array.Length; j = j + 2)
        sum = sum + array[j];
    return sum;
}

WriteLine("enter size of array: ");
int size = int.Parse(ReadLine());
int[] array = FillArray(size);
int sum = SumNumbersOddIndex(array);
WriteLine(String.Join(", ", array));
WriteLine($"the sum of numbers with an odd index in the array = {sum}");
