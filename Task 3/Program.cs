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
