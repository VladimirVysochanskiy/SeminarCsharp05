/* Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый 
и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */

const int LENGTH = 9;
const int FROMNUM = 0;
const int TONUM = 10;

Console.Clear();
int [] myarray = RandArray(LENGTH, FROMNUM, TONUM);
Console.WriteLine(string.Join(" | ", myarray));
Console.WriteLine(FindNumTotal(myarray, 10, 10));
Console.WriteLine(string.Join(" | ", ProductFirstAndLast(myarray)));

int[] RandArray(int length, int fromNum, int toNum)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(fromNum, toNum + 1);
    }
    return array;
}

int FindNumTotal(int[] array, int fromNum, int toNum)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= fromNum && array[i] <= toNum) count += 1;
    }
    return count;
}

int[] ProductFirstAndLast(int[] array)
{
    int length;

    if (array.Length % 2 == 0) length = array.Length / 2;
    else length = (array.Length / 2) + 1;

    int[] productArray = new int[length];

    for (int i = 0; i < productArray.Length; i++)
    {
        if (i != array.Length -1  - i)
        {
            productArray[i] = array[i] * array[array.Length - 1 - i];
        }

        if (i == array.Length - 1 - i)
        {
            productArray[i] = array[i];
        }
    }
    return productArray;
}
