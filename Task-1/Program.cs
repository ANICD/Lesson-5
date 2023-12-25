//Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.WriteLine("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] myTwoDimArr = FillArray(rows, cols);//Заполняем массив
Console.WriteLine("Наш массив: ");
PrintArray(myTwoDimArr);
Console.WriteLine("Введите позицию элемента массива в строке: ");
int rowIndex = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию элемента массива в столбце: ");
int colIndex = Convert.ToInt32(Console.ReadLine());
int foundElement = FindElementValue(rowIndex, colIndex, myTwoDimArr);
if (foundElement != -1)
{
    Console.WriteLine("Значение элемента в заданной позиции: {foundElement}");
}


//МЕТОД ПОИСКА ЗНАЧЕНИЯ ЭЛЕМЕНТА ДВУМЕРНОГО МАССИВА
int FindElementValue(int rowIndex, int colIndex, int[,] array)
{
    int elementValue = -1;
    if (rowIndex < array.GetLength(0) && colIndex <= array.GetLength(1))
        elementValue = array[rowIndex, colIndex];
    else
        Console.WriteLine("Элемента с индексом " + rowIndex + " " + colIndex + " не существует! Завершение программы!");
    return elementValue;
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