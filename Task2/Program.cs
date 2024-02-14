void PrintSquares(int n)
{
    int i = 1;
    while(i <= n)
    {
        Console.Write(i * i + " ");
        i++;
    }
    Console.WriteLine();
}

PrintSquares(5);
PrintSquares(10);
PrintSquares(15);
