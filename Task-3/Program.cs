//Задача 3: Задайте прямоугольный двумерный массив.
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.WriteLine("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] myTwoDimArr = FillArray(rows, cols);//Заполняем массив
Console.WriteLine("Массив, который заполнили: ");
PrintArray(myTwoDimArr);
Console.WriteLine();
int firstRowSum = 0;
int nextRowSum = 0;
int rowIndex = 0;

for (int j = 0; j < myTwoDimArr.GetLength(1); j++)
{
    firstRowSum += myTwoDimArr[0, j];
}

for (int i = 1; i < myTwoDimArr.GetLength(0); i++)
{
    for (int j = 0; j < myTwoDimArr.GetLength(1); j++)
    {
        nextRowSum += myTwoDimArr[i, j];
    }

    if (nextRowSum < firstRowSum)
    {
        firstRowSum = nextRowSum;
        rowIndex = i;
    }
    nextRowSum = 0;
}
Console.WriteLine("Индекс строки с минимальной суммой равен: " + rowIndex);

//===================================================
//МЕТОД ЗАПОЛНЕНИЯ ДВУМЕРНОГО МАССИВА
int[,] FillArray(int rows, int cols)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 11);
        }
    }
    return array;
}
//===================================================
//МЕТОД ВЫВОДА ДВУМЕРНОГО МАССИВА НА ЭКРАН
void PrintArray(int[,] array)
{
    int element;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            element = array[i, j];
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}