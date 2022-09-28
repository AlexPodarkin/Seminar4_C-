Console.Clear();
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col)
{   
    Console.Write($" [");
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($" {col[position]}, "); // Console.Write($"  index {position} = {col[position]}");
        position++;
    }
    Console.Write($"] ");
}

int[] array = new int[7];

FillArray(array);
PrintArray(array);

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArr(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}

PrintArr(arr);
SelectionSort(arr);

PrintArr(arr);
