double CalculateFormula(int a, int b, int c, int d)
{
    int nomenator = a * b;
    double denomenator = c + d;
    double result = nomenator / denomenator;
    return result;
}

Console.WriteLine(CalculateFormula(1, 2, 3, 4));