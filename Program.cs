int CutNumber(int number)
{
    int ed = number % 10;
    int sot = number / 100;

    number = sot * 10 + ed;
    return number;
}

int num = new Random().Next(100, 1000);

int result = CutNumber(num);
Console.WriteLine($"new version of a number {num} is {result}");
//345