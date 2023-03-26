// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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
    int nextNumber = 1;
    int[,] array = new int[numberRows, numberColumns];

    int roundNumbers = 0;
   
    while (nextNumber <= array.GetLength(0) * array.GetLength(1))
    {
        int i= roundNumbers;
        int j = roundNumbers;

        for (j = roundNumbers; j < numberColumns; j++)
        {
            array[i, j] = nextNumber;
            nextNumber++;
        }
        
        if (nextNumber > array.GetLength(0) * array.GetLength(1))
        {
            break;
        }
        j = numberColumns-1;
        for (i = roundNumbers+1; i < numberRows; i++)
        {
            array[i, j] = nextNumber;
            nextNumber++;
        }
        numberColumns--;
       
        i = numberRows-1;
        for (j = numberColumns-1; j >= roundNumbers ; j--)
        {
            array[i, j] = nextNumber;
            nextNumber++;
        }
        numberRows--;

        j = roundNumbers;
        roundNumbers++;
        for (i = numberRows - 1; i >= roundNumbers; i--)
        {
            array[i, j] = nextNumber;
            nextNumber++;
        }
    }

    return array;
}


int numberRows = Prompt("Введите значение количества строк массива: ");
int numberColumns = Prompt("Введите значение количества столбцов массива: ");

int[,] matrix = GenerateArray(numberRows, numberColumns);
PrintArray(matrix);



