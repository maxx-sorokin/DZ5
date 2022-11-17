int[] numbers = new int[6];

FillArray(numbers);
PrintArray(numbers);

Console.WriteLine($"Количество чётных чисел в массиве - {HowManyEvenNumbersInTheArray(numbers)}");

int HowManyEvenNumbersInTheArray (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] array)
{
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
        array[i] = random.Next(100, 1000);
    }
}