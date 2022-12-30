int NumFirst = 3;
int NumSecond = 4;

int Akkerman (int m, int n)
{
if (m == 0) return n+1;
else if (m > 0 && n == 0) return Akkerman(m - 1, 1);
else return Akkerman(m - 1, Akkerman (m, n - 1));
}

Console.Write(Akkerman(NumFirst,NumSecond));