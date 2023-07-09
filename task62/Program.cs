﻿// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



void ShowArray(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write(mass[i, j] + ", ");
        }

        Console.Write("\n");

    }
    Console.WriteLine("-----------------------------------------");
}

void SnackeArray(int[,] array)
{
    int n = array.GetLength(0);
    int m = array.GetLength(1);


    int row = 0;
    int col = 0;

    int x = 1;
    int y = 0;

    int dip = 0;
    int moove = m;

    int time;

    for (int i = 1; i <= m * n; i++)
    {
        array[row, col] = i;
        moove--;
        if (moove == 0)
        {
            moove = m * (dip % 2) + n * ((dip + 1) % 2) - (dip / 2 - 1) - 2;
            time = x;
            x = -y;
            y = time;
            dip++;
        }
        col += x;
        row += y;
    }




}

const int lenght = 4;
const int lenght2 = 6;

int[,] arraysnack = new int[lenght, lenght2];

SnackeArray(arraysnack);
ShowArray(arraysnack);