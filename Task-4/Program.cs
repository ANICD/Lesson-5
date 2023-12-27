//Задача 4*(не обязательная): Задайте двумерный массив из целых чисел.
//Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
//Под удалением понимается создание нового двумерного массива без строки и столбца
Console.WriteLine("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] myTwoDimArr = FillArray(rows, cols);//Заполняем массив
Console.WriteLine("Массив, который заполнили: ");
PrintArray(myTwoDimArr);
Console.WriteLine();
int minElementVal = myTwoDimArr[0, 0];
int elementRowIndex = 0;
int elementColIndex = 0;
// Находим минимальный элемент и его индексы
for (int i = 0; i < myTwoDimArr.GetLength(0); i++)
{
    for (int j = 0; j < myTwoDimArr.GetLength(1); j++)
    {
        if (myTwoDimArr[i, j] < minElementVal)
        {
            minElementVal = myTwoDimArr[i, j];
            elementRowIndex = i;
            elementColIndex = j;
        }
    }
}
// Выводим минимальный элемент и его индексы
Console.WriteLine("Первый минимальный элемент равен: " + minElementVal + "; " + "Индекс равен: " + elementRowIndex + " " + elementColIndex);
Console.WriteLine("Удаляем строку и столбец элемента с индексом: " + elementRowIndex + " " + elementColIndex);

// Создаем новый массив, удаляя строку и столбец минимального элемента
int[,] newArr = new int[myTwoDimArr.GetLength(0) - 1, myTwoDimArr.GetLength(1) - 1];
for (int i = 0; i < myTwoDimArr.GetLength(0); i++)
{
    // Пропускаем строку с минимальным элементом
    if (i != elementRowIndex)
    {
        for (int j = 0; j < myTwoDimArr.GetLength(1); j++)
        {
            // Пропускаем столбец с минимальным элементом
            if (j != elementColIndex)
            {
                // Копируем элементы в новый массив
                int newRow, newCol;
                if (i < elementRowIndex)
                    newRow = i;
                else
                    newRow = i - 1;

                if (j < elementColIndex)
                    newCol = j;
                else
                    newCol = j - 1;
                newArr[newRow, newCol] = myTwoDimArr[i, j];
            }
        }
    }
}
PrintArray(newArr);
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
