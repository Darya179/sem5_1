int[] array = getArray(10, 100, 999);

int[] getArray(int size, int min, int max)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    Console.WriteLine("Массив: {0}{1}{2}", "[", String.Join(", ", result), "]");
    return result;
}

int Kol(int[] arr)
{
    int j = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2 == 0) j = j + 1;
    }

    return j;
}

Console.WriteLine($"Количество четных элементов: { Kol(array) }");