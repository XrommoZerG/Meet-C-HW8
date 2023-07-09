// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 6 16
// 9 6


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

int[,] Dec(int[,] arr1, int[,] arr2)
{
    int[,] newarr = new int[arr1.GetLength(0), arr2.GetLength(1)];

    for (int i = 0; i < newarr.GetLength(0); i++)
    {
        for (int j = 0; j < newarr.GetLength(1); j++)
        {
            Console.WriteLine("------------" + j);

            for (int h = 0; h < arr2.GetLength(0); h++)
            {
                newarr[i, j] += arr1[i, h] * arr2[h, j];
                Console.WriteLine(newarr[i, j]);

            }
            Console.WriteLine("------------");


        }

    }



    return newarr;
}

const int lenght = 3;
const int lenght2 = 4;
const int lenght3 = 1;


int[,] array1 = new int[lenght, lenght2];
int[,] array2 = new int[lenght2, lenght3];



RandomArrayD(array1);
RandomArrayD(array2);
ShowArray(array1);
ShowArray(array2);

if (array1.GetLength(1) == array2.GetLength(0))
{
    int[,] resultarray = Dec(array1, array2);
    ShowArray(resultarray);
}
else{
    Console.WriteLine("Умножение матриц невозможно по скольку количество столбцов в первой матрице не равна количеству строк во второй матрице");
}



