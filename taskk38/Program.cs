﻿//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] num = new double[size];
FillArrayRandomNumbers(num);
Console.WriteLine("Вот наш массив: ");
PrintArray(num);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < num.Length; z++)
{
    if (num[z] > max)
        {
            max = num[z];
        }
    if (num[z] < min)
        {
            min = num[z];
        }
}

Console.WriteLine($"Всего {num.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(double[] num)
{
    for(int i = 0; i < num.Length; i++)
        {
            num[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] num)
{
    Console.Write("[ ");
    for(int i = 0; i < num.Length; i++)
        {
            Console.Write(num[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}

