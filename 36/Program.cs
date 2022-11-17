int[] numbers = new int[6];

FillArray(numbers);
PrintArray(numbers);

Console.WriteLine($"Сумма элементов на чётных позициях - {FindsSumOfElementsInOddPositions(numbers)}");

int FindsSumOfElementsInOddPositions(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

void PrintArray(int[] array)
{
    Console.WriteLine();
    for (var i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void FillArray(int[] array)
{
    Random random = new Random();
    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-10, 11);
    }
}