int NumFirst = 1;
int NumSecond = 20;

int Line(int n, int m, int sum = 0)
{
    if (n > m)
    {
        Console.WriteLine("Первое число больше второго");
        return 0;
    }
    else if (n == m)
    {
        return sum += m;
    }
    else
    {
        sum += m;
        return Line(n, m - 1 , sum);
    }
}

Console.WriteLine(Line(NumFirst, NumSecond));