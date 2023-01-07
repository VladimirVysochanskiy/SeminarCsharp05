/* Задайте массив вещественных чисел. Найдите разницу между максимальным и 
минимальным элементов массива.
[3 7 22 2 78] -> 76  */

Console.Clear();
const int ARRLENGTH = 20;
const int FROMNUM = 0;
const int TONUM = 10;

double[] myarray = RandArray(ARRLENGTH, FROMNUM, TONUM);
Console.WriteLine(string.Join(" | ", myarray));
ArraySortMinMax(myarray);
System.Console.WriteLine();
Console.WriteLine(string.Join(" | ", myarray));
System.Console.WriteLine();
System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {myarray[^1] - myarray[0]}");





//Mетод Cоздание и рандомное наполнение 1D double массива
double[] RandArray(int length, int fromNum, int toNum)
{
    double[] array = new double[length];
    Random rand = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = Math.Round(rand.Next(fromNum, toNum) + rand.NextDouble(), 3);
    }
    return array;
}

void ArraySortMinMax(double[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        double temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

