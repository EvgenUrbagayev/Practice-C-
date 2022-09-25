

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};  // массив, который необходимо отсортировать

void PrintArray(int[] array)  // вывод на экран (метод void, в качестве аргумента будет приходить массив)
{
    int count = array.Length;
    for (int i = 0; i < count; i++) // пробегаем по всему массиву
    {
        Console.Write($"{array[i]}  "); // и показываем на экране
    }
}

void SelectionSort(int[] array)  // метод, который упорядочивает массив. В качестве аргумента приходит массив
{
    for (int i = 0; i < array.Length - 1; i++)   // пробегаемся по всему массиву
    {
        int minPosition = i;  // запоминаем позицию с которой будем работать
        
        for (int j = i + 1; j < array.Length; j++) // начинаем поиск от индекса i+1
        {
            if(array[j] < array[minPosition]) minPosition = j; // ищем минимальный элемент и сохраняем в j
        }

        int temporary = array[i];  // обмен
        array[i] = array[minPosition];  //  двух переменных
        array[minPosition] = temporary;  // местами

    }
}


PrintArray(arr);
SelectionSort(arr); // вызываем упорядочивание массива

PrintArray(arr);

