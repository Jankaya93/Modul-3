void FillArray(int[] collection)    // подставляет рандомные значения от 1 до 10 в массив
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)  // выводит на экран значение каждой позиции рандомного массива
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.Write(col[position] + " ");
        position++;
    }
}

int IndexOf(int[] collection, int find) // ищет индекс заданного числа в массиве (первое вхождение). Если элемента в массиве нет выведет -1
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];  //создает массив из 10 элементов, которые заполнены 0 если иные значения не указаны

FillArray(array);
PrintArray(array);
System.Console.WriteLine();

int pos = IndexOf(array, 4);
System.Console.WriteLine(pos);