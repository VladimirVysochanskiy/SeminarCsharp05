/*Напишите программу замена элементов массива: положительные элементы 
замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]  */

int[] RandArray(int length, int fromNum, int toNum)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(fromNum, toNum + 1);
    }
    return array;
}

void ChangeNegativePositive(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
}

void FindNumber(int[] array, int number)
{
    string find = "НЕТ";
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            find = "ДА";
            break;
        }
    }
    System.Console.WriteLine(find);
}

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


int[] arr = RandArray(15, -20, 20);
System.Console.WriteLine(string.Join(" | ", arr));
ChangeNegativePositive(arr);
System.Console.WriteLine(string.Join(" | ", arr));
FindNumber(arr, 8);

