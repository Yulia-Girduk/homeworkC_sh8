// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.

// Выводим сообщения для пользователя и возвращаем введенные данные пользователем
int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// Выводим массив на экран
void PrintArray(int[,] tableArray)
{
    Console.WriteLine();
    for (int i = 0; i < tableArray.GetLength(0); i++)
    {
        for (int j = 0; j < tableArray.GetLength(1); j++)
        {
            Console.Write($"{tableArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}

// Генерируем (задаем) массив
int[,] GenerateArray(int numberRows, int numberColumns)
{
    Random random = new Random();
    int[,] array = new int[numberRows, numberColumns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
    return array;
}

// Упорядочит элементы массива по убыванию
int[,] OrganizeElementsDecrease(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int n = 0; n < array.GetLength(1) - 1; n++)
            {
                if (array[i, n] < array[i, n + 1])
                {
                    int temp = array[i, n];
                    array[i, n] = array[i, n + 1];
                    array[i, n + 1] = temp;
                }
            }
        }
    }
    return array;
}

int numberRows = Prompt("Введите значение количества строк массива: ");
int numberColumns = Prompt("Введите значение количества столбцов массива: ");

int[,] matrix = GenerateArray(numberRows, numberColumns);
PrintArray(matrix);

matrix = OrganizeElementsDecrease(matrix);
PrintArray(matrix);

