//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
using static System.Console;

int[] FillArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
    return array;
}
int CountEvenNumbers(int[] array)
{
    int count = 0;
    for(int j = 0; j < array.Length; j++)
    {
        if(array[j]%2 == 0)
        {
            count++;
        }
    }
    return count;
}

WriteLine("enter size of array: ");
int size = int.Parse(ReadLine());
int[] array = FillArray(size);
int count = CountEvenNumbers(array);
WriteLine(String.Join(", ", array));
WriteLine($"quantity of even numbers in the array = {count}");

