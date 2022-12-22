int PositiveCount()
{
    string MessageText = "0";
    int MasLength = 1;
    int[] PreviousMas = new int[0];
    int positive = 0;

    for(int i = 0; i < MasLength; i++)
    {
        Console.WriteLine("Введите число");
        MessageText = Console.ReadLine();
        if (MessageText != "stop")
        {
            int message = Convert.ToInt32(MessageText);
            int[] array = new int [MasLength];
            for(int j = 0; j < MasLength - 1; j++)
            {
                array[j] = PreviousMas[j];
            }
            if (message > 0)
            {
                positive += 1;
            }
            array[MasLength - 1] = message;
            PreviousMas = array;
            MasLength += 1;
        }
    }
    return positive;
}

Console.WriteLine($"Количество положительных чисел = {PositiveCount()}");