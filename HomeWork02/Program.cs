/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

Console.Clear();
const int ARRLENGTH = 20;
const int FROMNUM = 0;
const int TONUM = 20;

int[] myarray = RandArray(ARRLENGTH, FROMNUM, TONUM);
Console.WriteLine(string.Join(" | ", myarray));
System.Console.WriteLine();
Console.WriteLine($"Сумма элементов с нечетными индексами = {SumOddIndex1DArr(myarray)}");

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

int SumOddIndex1DArr(int[] array)
{
    int count = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        count += array[i];
    }
    return count;
}
