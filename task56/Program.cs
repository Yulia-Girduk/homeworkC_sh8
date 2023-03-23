// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

// Выводим сообщения для пользователя и возвращаем введенные данные пользователем
int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// Выводим массив на экран
void PrintTableArray(int[,] tableArray)
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
int[,] GenerateArray(int numberRows, int numberColumns, int numberStart, int numberEnd)
{
    Random random = new Random();
    int[,] array = new int[numberRows, numberColumns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(numberStart, numberEnd);
        }
    }
    return array;
}

// Получаем дономерный массив суммы строк двумерного массива 
// 
int[] GetSumLinesArray(int[,] tableArray)
{
    
}

(int,int) GetMinElement(int[] array)
{

}

int numberRows = Prompt("Введите значение количества строк массива: ");
int numberColumns = Prompt("Введите значение количества столбцов массива: ");
int numberStart = Prompt("Введите начальное значение для заполнения массива: ");
int numberEnd = Prompt("Введите конечное значение для заполнения массива: ");

int[,] matrix = GenerateArray(numberRows, numberColumns, numberStart, numberStart);

Console.WriteLine("Заданный массив: ")
PrintTableArray(matrix);

int[] sumElementsLinesArray = GetSumLinesArray(matrix);


(int minSum, int indexRow ) minSum = GetMinElement(sumElementsLinesArray);
Console.WriteLine($"Наименьшая сумма элементов массива = {minSum} находится в строки {indexRow}");

