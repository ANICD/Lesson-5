//Задача 2: Задайте двумерный массив.
//Напишите программу, которая поменяет местами первую и последнюю строку массива.
Console.WriteLine("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] myTwoDimArr = FillArray(rows, cols);//Заполняем массив
Console.WriteLine("Массив, который заполнили: ");
PrintArray(myTwoDimArr);
Console.WriteLine();
Console.WriteLine("Массив, в котором поменяли первую и последнюю строки: ");
ChangeRows(myTwoDimArr);
PrintArray(myTwoDimArr);
//==================================================
//МЕТОД ЗАМЕНЫ ЭЛЕМЕНТОВ ПЕРВОЙ И ПОСЛЕДНЕЙ СТРОК ДВУМЕРНОГО МАССИВА
void ChangeRows(int[,] array)
{
    int firstRow = 0;
    int lastRow = array.GetLength(0) - 1;
    int colCount = array.GetLength(1);
    for (int j = 0; j < colCount; j++)
    {
        int tempElement = array[firstRow, j];
        array[firstRow, j] = array[lastRow, j];
        array[lastRow, j] = tempElement;
    }
}
//===================================================
//МЕТОД ЗАПОЛНЕНИЯ ДВУМЕРНОГО МАССИВА
int[,] FillArray(int rows, int cols)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
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