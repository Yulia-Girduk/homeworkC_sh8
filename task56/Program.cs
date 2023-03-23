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

// Вывод одномерного массива
void PrintArray(int[] array)
{
    Console.WriteLine($"[{String.Join(",", array)}]");
}

// Получаем одономерный массив суммы строк двумерного массива. 
// Индекс элемента одномерного массива = номеру строки двумерного массива
int[] GetSumLinesArray(int[,] tableArray)
{
   int[] sumElementsLinesArray = new int[tableArray.GetLength(0)];
   int sum = 0;
   for (int i = 0; i < tableArray.GetLength(0); i++)
   {
    for (int j = 0; j < tableArray.GetLength(1); j++)
    {
        sum += tableArray[i,j];
    }
    sumElementsLinesArray[i] = sum;
    sum=0;
   }
   return sumElementsLinesArray;  
}

// Получаем минимальный элемент массива и его индекс.
(int,int) GetMinElement(int[] array)
{
    int minElement = array[0];
    int minIndex = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minElement)
        {
            minElement = array[i];
            minIndex = i;
        }
    }
    return (minElement, minIndex);
}

int numberRows = Prompt("Введите значение количества строк массива: ");
int numberColumns = Prompt("Введите значение количества столбцов массива: ");
int numberStart = Prompt("Введите начальное значение для заполнения массива: ");
int numberEnd = Prompt("Введите конечное значение для заполнения массива: ");

int[,] matrix = GenerateArray(numberRows, numberColumns, numberStart, numberEnd);

Console.WriteLine("Заданный массив: ");
PrintTableArray(matrix);

int[] sumElementsLinesArray = GetSumLinesArray(matrix);

Console.WriteLine("Массив сумм строк заданного двумерного массива: ");
PrintArray(sumElementsLinesArray);

(int minSum, int indexRow ) = GetMinElement(sumElementsLinesArray);
Console.WriteLine($"Наименьшая сумма элементов массива = {minSum} находится в строке {indexRow}");

