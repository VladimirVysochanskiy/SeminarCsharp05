//Задайте массив из 12 элементов, заполненный случайными числами из промежутка
//[-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

int[] newArray = RandArray(12, -9, 9);
int[] minMax = SumOfPositiveAndNegativeItems(newArray);

System.Console.WriteLine(string.Join(" | ", newArray));
System.Console.WriteLine($"Сумма отрицательных чисел: {minMax[0]}");
System.Console.WriteLine($"Сумма положительных чисел: {minMax[1]}");


//---------------------------------------------------------------------------
//Метод подсчёта сумм отрицательных и положительных элементов 1D массива.
int[] SumOfPositiveAndNegativeItems(int[] array)
{
    int[] totals = new int[2];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) totals[0] += array[i];
        else totals[1] += array[i];
    }
    return totals;
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
