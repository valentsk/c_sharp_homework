// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

int[,,] array = new int[2, 2, 2]; // создаем массив
FillArray(array); // заполняем
bool resultBool = ThirdMatrixInOneArrayDontRepeat(array); // трехмерный массив в одномерный c сортировкой и проверкой повторных чисел
PrintRandom(resultBool); // печатает массив, если не повторяются значение

bool ThirdMatrixInOneArrayDontRepeat(int[,,] array)
{
    int[] rowArray = MatrixToRow(array); // трехмерный массив в одномерный
    SortArray(rowArray); // сортируем
    // PrintOneArray(rowArray); // смотрим сортированный
    Console.WriteLine();
    bool resBool = GetFrequense(rowArray);
    return resBool; // если повторяются символы, то должен Фолс
}


void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

void FillArray(int[,,] array)
{
    Random generator = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = generator.Next(0, 100);
            }
        }
    }
}

int[] MatrixToRow(int[,,] matrix)
{
    int[] result = new int[matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2)];
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                result[index] = matrix[i, j, k];
                index++;
            }
        }
    }
    return result;
}

void SortArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        for (int j = i + 1; j < inArray.Length; j++)
        {
            if (inArray[i] > inArray[j])
            {
                int k = inArray[i];
                inArray[i] = inArray[j];
                inArray[j] = k;
            }
        }
    }
}

void PrintOneArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");

    }
}

bool GetFrequense(int[] sortedArray)
{
    bool result = true;
    int currentElement = sortedArray[0];
    int count = 1;
    for (int i = 1; i < sortedArray.Length; i++)
    {
        if (sortedArray[i] == currentElement)
        {
            currentElement = sortedArray[i];
            return false;
        }
        else
        {
            currentElement = sortedArray[i];
        }
    }
    return true;
}

void PrintRandom(bool resultBoolean)
{
    if (resultBoolean == true)
    {
        PrintArray(array);
    }
    else
    {
        // Console.WriteLine("Еще раз"); смотрим запустились ли по новой методы 
        FillArray(array);
        bool resBool = ThirdMatrixInOneArrayDontRepeat(array); 
        PrintRandom(resBool);
    }
}