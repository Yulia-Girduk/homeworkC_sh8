// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

// Выводим сообщения для пользователя и возвращаем введенные данные пользователем
int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int GetNonRepeatNumber(int[] array)
{
    int newNumber = new Random().Next(10, 100);
    if (Array.IndexOf(array, newNumber) < 0)
    {
        return newNumber;
    }
    else
    {
        return GetNonRepeatNumber(array);
    }
}

// Генерируем (задаем) массив 
int[,,] GenerateArray(int dimensionA, int dimensionB, int dimensionC)
{
    int arrayRepeatNumberLength = dimensionA * dimensionB * dimensionC;

    int[] arrayRepeatNumber = new int[arrayRepeatNumberLength];
    int n = 0;
    int[,,] array3D = new int[dimensionA, dimensionB, dimensionC];

    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i, j, k] = GetNonRepeatNumber(arrayRepeatNumber);
                arrayRepeatNumber[n] = array3D[i, j, k];
            }
        }

    }
    return array3D;
}

//Выводим массив
void PrintArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]}({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
    }
}

int dimensionA = Prompt("Введите значение измерения A трехмерного массива: ");
int dimensionB = Prompt("Введите значение измерения B трехмерного массива: ");
int dimensionC = Prompt("Введите значение измерения C трехмерного массива: ");

int[,,] array3D = GenerateArray(dimensionA, dimensionB, dimensionC);
PrintArray(array3D);






