// Задача 72: Заданы 2 массива: info и data. В массиве info хранятся двоичные представления 
// нескольких чисел (без разделителя). В массиве data хранится информация о количестве бит, 
// которые занимают числа из массива info. Напишите программу, которая составит массив десятичных 
// представлений чисел массива data с учётом информации из массива info.
// входные данные:	data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }	info = {2, 3, 3, 1 }
// выходные данные:	1, 7, 0, 1

int[] arrayData = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] arrayInfo = { 2, 3, 3, 1 };
PrintArray(BinToDecArray(arrayData, arrayInfo));

//  int[] arrayData = { 1, 1, 1, 1, 1, 0, 0, 0, 1 };
//  int[] arrayInfo = { 3, 2, 3, 1 };

int[] BinToDecArray(int[] arrayData, int[] arrayInfo)
{
    int[] arrayDec = new int[arrayInfo.Length];

    int countInfoData = 0; // j будет меняться от нуля до Х, от Х до У, и тд
    for (int i = 0; i < arrayInfo.Length; i++) 
    {
        int decNum = 0;
        int countBin = 0; // вместо j (который постоянно растет)
        for (int j = countInfoData; j < (countInfoData + arrayInfo[i]); j++)
        {
            arrayData[j] = arrayData[j] * (int)Math.Pow(2, arrayInfo[i] - countBin - 1);
            decNum += arrayData[j];
            countBin++;
        }
        countInfoData += arrayInfo[i];
        arrayDec[i] = decNum;
    }
    return arrayDec;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}