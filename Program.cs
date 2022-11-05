/*
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
*/

/*
bool IsEven(int number)
{
if(number % 2 == 0)
{
    return true;
}
else
{
    return false;
}
}

int num = new Random().Next(100, 1000);

bool res = IsEven(num);
Console.WriteLine($"number {num} is {res}");
*/

/*
int MaxNum(int randnum)
{
    int max = 0;
    int ed = randnum % 10;
    int doz = randnum / 10;
    if(ed > doz)
    {
        max = ed;
    }
    else
    {
        max = doz;
    }
    return max;
}

int number = new Random().Next(10, 100);
int result = MaxNum(number);

Console.WriteLine($"Max nuber of a {number} is {result}");
*/


/*
bool Multiplicity(int firstnum, int secondnum)
{
    if(secondnum % firstnum ==0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine("input first number ");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input second number ");
int second = Convert.ToInt32(Console.ReadLine());

bool res = Multiplicity(first, second);
Console.WriteLine(res);
*/