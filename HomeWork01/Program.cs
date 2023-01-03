/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

Console.Clear();
const int ARRLENGTH = 30;
const int FROMNUM = 100;
const int TONUM = 999;

int[] myarray = RandArray(ARRLENGTH, FROMNUM, TONUM);
Console.WriteLine(string.Join(" | ", myarray));
Console.WriteLine();
Console.WriteLine($"В массиве myarray найдено {TotalEvenIn1DArray(myarray)} четных чисел.");
Console.WriteLine();


//метод создание и рандомное наполнение int массива (заданной длины, числами от, и до)
int[] RandArray(int length, int fromNum, int toNum)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(fromNum, toNum + 1);
    }
    return array;
}
/*
//Метод контроля ввода числа.
int InputNumberControl(string text)
{
    System.Console.Write(text);
    int number;
    while (true)    
    {
        string? txt = (Console.ReadLine());
        if (int.TryParse(txt, out number))
        {
            break;
        }
        System.Console.Write("Введенное значение не является натуральным числом. Попробуйте ещё раз: ");
    }  
    return number;
}

//Метод подсчета вхождений указанного числа или диапазона в 1D массиве
int FindNumTotal(int[] array, int fromNum, int toNum)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= fromNum && array[i] <= toNum) count += 1;
    }
    return count;
}
*/

int TotalEvenIn1DArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 ==0) count++;
    }
    return count;
}
