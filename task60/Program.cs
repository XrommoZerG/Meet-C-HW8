// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// Показывает трёхмерный масив
void ShowArray(int[,,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            for (int h = 0; h < mass.GetLength(2); h++)
            {
                Console.Write($"{mass[i, j, h]}({i},{j},{h});  ");

            }
            Console.Write("\n");

        }

        Console.Write("\n");

    }
    Console.WriteLine("-----------------------------------------");
}

// Заполняет трёхмерный масив случайными не повторяющими цифрами
void RandomArrayD(int[,,] mass, int lenghtleft, int lenghtright)
{
    int randomnumber;
    int[] arraynumber = new int[0];
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            for (int h = 0; h < mass.GetLength(2); h++)
            {
                do
                {
                    randomnumber = Random.Shared.Next(lenghtleft, lenghtright);
                } while (Contains(arraynumber, randomnumber) != false); 
                arraynumber = Resize(arraynumber, randomnumber);


                mass[i, j, h] = randomnumber;

            }
        }
    }
}
// Увеличавает длину масива на 1 и добавляет в конец новую цифру
int[] Resize(int[] arr, int number)
{

    int[] newArr = new int[arr.Length + 1];

    for (int i = 0; i < arr.Length; i++)
    {
        newArr[i] = arr[i];
    }

    newArr[newArr.Length - 1] = number;

    return newArr;

}
// Проверяет ест ли в даном масиве такая цифра и возвращает true если есть в противном случае false
bool Contains(int[] arr, int number)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == number)
        {
            return true;
        }
    }
    return false;
}

const int lenght = 3;
const int lenght2 = 4;
const int lenght3 = 2;

const int lenghtleft = 0;
const int lenghtright = 100;




int[,,] array1 = new int[lenght, lenght2, lenght3];

// Проверяет есть ли столько уникальных чисел для заполнения матрицы (по умолчаю все переменые константы)
if ((lenghtright - lenghtleft) < (lenght * lenght2 * lenght3))
{
    Console.WriteLine("Нету столько уникальных чисел для заполнения иатрицы");

}
else
{
    RandomArrayD(array1, lenghtleft, lenghtright);
    ShowArray(array1);
}





