int NumFirst = 1;
int NumSecond = 4;

void Line(int n, int m)
{
    if (n > m)
    {
        Console.WriteLine("Первое число больше второго");
    }
    else if (n == m)
    {
        Console.Write(m);
    }
    else
    {
        Console.Write(m);
        Line(n, m - 1);
    }
}

Line(NumFirst, NumSecond);