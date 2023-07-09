// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


void ShowArray(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        Console.Write($" Строка - {i}: ");
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write(mass[i, j] + ", ");
        }

        Console.Write("\n");

    }
    Console.WriteLine("-----------------------------------------");
}
void RandomArrayD(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = Random.Shared.Next(10);
        }
    }
}

int SumRowShow(int[,] arr)
{
    int minrowpoz = 0;
    int sum = 0;
    int minsum = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        if (i == 0)
        {
            minsum = sum;
            minrowpoz = i;
        }
        else if (minsum > sum)
        {
            minsum = sum;
            minrowpoz = i;
        }
    }
    return minrowpoz;
}

const int lenght = 5;
const int lenght2 = 6;


int[,] array = new int[lenght, lenght2];
RandomArrayD(array);
ShowArray(array);
Console.WriteLine($"Минимальная сума елементов в {SumRowShow(array)} строке");