// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

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

// Проверяем возможно ли перемножить массивы
bool ChekCanMultiplyArrays(int countColumnsA, int countRowsB)
{
    if (countColumnsA == countRowsB)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int[,] MultiplyTwoArrays(int[,] arrayA, int[,] arrayB)
{
    if (ChekCanMultiplyArrays(arrayA.GetLength(1), arrayB.GetLength(0)))
    {
        int[,] arrayMultiply = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
        for (int i = 0; i < arrayA.GetLength(0); i++)
        {
            for (int j = 0; j < arrayB.GetLength(1); j++)
            {
                for (int n = 0; n < arrayB.GetLength(0); n++)
                {
                    arrayMultiply[i,j] += arrayA[i,n]*arrayB[n,j];
                }
                
            }
            
        }

        return arrayMultiply;
    }
    else throw new Exception($"Не возможно перемножить массивы количество столбцов массива А ({arrayA.GetLength(1)}) не равно количеству строк массива В ({ arrayB.GetLength(0) })!");
}

int numberRowsA = Prompt("Введите значение количества строк массива A: ");
int numberColumnsA = Prompt("Введите значение количества столбцов массива A: ");

int numberRowsB = Prompt("Введите значение количества строк массива B: ");
int numberColumnsB = Prompt("Введите значение количества столбцов массива B: ");

int numberStart = Prompt("Введите начальное значение для заполнения массива: ");
int numberEnd = Prompt("Введите конечное значение для заполнения массива: ");


int[,] matrixA = GenerateArray(numberRowsA, numberColumnsA, numberStart, numberEnd);
int[,] matrixB = GenerateArray(numberRowsB, numberColumnsB, numberStart, numberEnd);

Console.WriteLine("Массив A: ");
PrintTableArray(matrixA);

Console.WriteLine("Массив B: ");
PrintTableArray(matrixB);

try
{
    int[,] matrixMultiply = MultiplyTwoArrays(matrixA, matrixB);
    Console.WriteLine("Массив произведений: ");
    PrintTableArray(matrixMultiply);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}



