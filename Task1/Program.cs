void ZeroEvenElements(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}

void PrintArray(int[] arr)
{
    foreach (int a in arr)
    {
        Console.Write($"{a} ");
    }
}

int[] array = { 1, 2, 3, 4, 5 };
ZeroEvenElements(array);
PrintArray(array);

