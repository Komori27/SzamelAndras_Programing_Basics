/*
double x = 3;
double p = Math.Pow(x, 5);

float y = Math.Abs(-4);

float z = Abs(4);

WriteCounting(10);
WriteCounting(7);
WriteCounting(3);



float Abs(float input)
{
    if (input < 0)
        input = input * -1;

    return input;
}

void WriteCounting(int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine(i);
    }
}
*/

// ----------- első N prím ----------------

bool IsPrime(int number)
{
    for (int i = 2; i <= number / 2; i++)
    {
        if (number % i == 0)
            return false;
    }

    return true;
}


// int n = 17;
WriteFirstNPrime (10000);
/*
void WriteFirstNPrime(int n)
{
    for (int i = 1; i <= n; i++)
    {
        bool x = IsPrime(n);
        if (x = true)
            Console.WriteLine(i);
    }
}
*/

void WriteFirstNPrime(int n)
{
    int found = 0;

    for (int i = 2; found < n; i++)
    {
        if (IsPrime(i))
        {
            Console.WriteLine(found+1 + " " + i);
            found++;
        }
    }
}
