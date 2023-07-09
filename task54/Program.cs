// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortArray(int[,] arr)
{

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int h = 0; h < arr.GetLength(1); h++)
        {
            if (arr[i,j] <= arr[i,h])
            {
                continue;
            }
            int temp = arr[i,j];
            arr[i,j] = arr[i,h];
            arr[i,h] = temp;
            
        }
        
    }
    
}

}


const int lenght = 5;
const int lenght2 = 6;


int[,] array = new int[lenght, lenght2];
RandomArrayD(array);
ShowArray(array);
SortArray(array);
ShowArray(array);
