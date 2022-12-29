//Задайте массив из 12 элементов, заполненный случайными числами из промежутка
//[-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

//---------------------------------------------------------------------------
//Метод подсчёта сумм отрицательных и положительных элементов 1D массива.
void SumOfPositiveAndNegativeItems(int[] array, out int sumN, out int sumP)
{
    sumN = 0;
    sumP = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sumN += array[i];
        else sumP += array[i];
    }
}

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

//Метод контроля ввода числа.
/*int InputNumberControl(string text)
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
*/

int[] newArray = RandArray(12, -9, 9);
SumOfPositiveAndNegativeItems(newArray, out int sumNegative, out int sumPositive);

System.Console.WriteLine(string.Join(" | ", newArray));
System.Console.WriteLine($"Сумма отрицательных чисел: {sumNegative}");
System.Console.WriteLine($"Сумма положительных чисел: {sumPositive}");