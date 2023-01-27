/*
Console.WriteLine("Hello World");

// elágazások

int ammo = 10;
bool isInAir = false;

if (ammo > 0 && !isInAir) 
{
    Console.WriteLine("BOOM!");
    ammo--;
}

bool isGrounded = !isInAir;
bool haveAmmo = ammo > 0;
bool canShoot = haveAmmo && isGrounded;

if (canShoot)
{
    Console.WriteLine("BOOM!");
}

else
{
    Console.WriteLine("click...");
}

// ---------------------------------------

Console.WriteLine("Írj be egy egész számot:");
string line = Console.ReadLine();
int number = int.Parse(line);

Console.WriteLine(number + " duplája:");
Console.WriteLine(number * 2);
*/

// -----------------------------------------

/*
Console.WriteLine("Írj be egy egész számot:");
//Páros vagy Páratlan
string line2 = Console.ReadLine();
int number2 = int.Parse(line2);

int number3 = number2 / 2;

bool even = number2 3;

if (even)
{
    
}
*/

/*
string line = Console.ReadLine();
int number = int.Parse(line);

bool isEven = number % 2 == 0;

if (isEven)
{
    Console.WriteLine("Páros!");
}
else
{
    Console.WriteLine("Páratlan");
}
*/

// -----------------------------------------

//  pozitív / negatív

/*

Console.WriteLine("Írj be egy számot:");
string line = Console.ReadLine();
int number = int.Parse(line);


if (number > 0)
{
    Console.WriteLine("Pozitív");
}
else
{
    if (number < 0)
    {
        Console.WriteLine("Negatív");
    }
    else
    {
        Console.WriteLine("Nulla");
    }
}

if (number > 0)
    Console.WriteLine("Pozitív");       //egy sor esetén elhagyható a {}

else if (number < 0)
{
    Console.WriteLine("Negatív");
}
else
{
    Console.WriteLine("Nulla");
}

*/

//----------------

//kerek / nem kerek

/*
Console.WriteLine("Írj be egy számot:");
string line = Console.ReadLine();
int number = int.Parse(line);

string text = number % 10 == 0 ? "Kerek!" : "Nem Kerek!"; // a ? b : c   /feltételes operátor      ha "a" igaz akkor "b", ha nem akkor "c"    / if - else , csak értékekhez

 string a
    if (feltétel)
    {
        a = "xyz"
    }
    else
    {
        a= "abc"
    }
 
Console.WriteLine(text);
*/
// ---------------CIKLUSOK-------------------
/*
int i = 1;      //ciklusváltozó

while (i <= 100)
{
    Console.WriteLine(i);
    i++;
}

for (int j = 1; j <= 100; j++)          //j változó csak az adott ciklusban él
{
    Console.WriteLine(j);
}
*/

//--------------------------------------------

/*
Console.WriteLine("Írj be egy számot:");
string line = Console.ReadLine();
int i2 = int.Parse(line);

for (int i1 = 1; i1 <= 100; i1++) 
{
    if (i1 % 3) 
    {
        Console.WriteLine(i1);
    }
}
*/

//első n pozitív egész szám ami osztható 5-el de nem osztható 7-el

/*
for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(i * 3)
}
*/
/*
Console.WriteLine("Írj be egy számot:");
string line = Console.ReadLine();
int n = int.Parse(line);

int x = 5;
int count = 0;

for (int i = 1; count < n; i++)
{
    int numberToWrite = i * x;
    bool devisibleWith7 = numberToWrite % 3 == 0;

    if (!devisibleWith7)     
    {
        Console.WriteLine(numberToWrite);
        count++;
    }
}
*/
// -------------------------------------------
/*
int a = 1;
int count = a * 10;
int b = 1;

for (int i = 1; i <= count; i++)
{
    Console.WriteLine(a * b);

}
*/

//szorzótábla
/*
for (int i = 1; i <= 10; i++)
{

    for (int j = 1; j <= 10; j++)
    {
        int result = j * i;
        Console.WriteLine(j + "*" + i + "=" + result);
    }
}
*/

// --------------------------------------------------
// Metódusok
/*
double f1 = 12.5f;      //double is egy floating point szám
double f2 = 3;

double power = Math.Pow(f1,f2);
double power2 = Math.Pow(45, 11.5);

Console.WriteLine(f1 + " ^ " + f2 + " = " + power);

double f3 = Math.Abs(f1);

double pi = Math.PI;
*/


/*
Console.WriteLine("Num. 1:");
string line1 = Console.ReadLine();
float a = float.Parse(line1);

Console.WriteLine("Num. 2:");
string line2 = Console.ReadLine();
float b = float.Parse(line2);

float sum = a + b;
float difference = a - b;
float product = a * b;
float quotient = a / b;

Console.WriteLine("Sum:" + sum);
Console.WriteLine("difference:" + difference);
Console.WriteLine("product:" + product);
Console.WriteLine("quotient:" + quotient);
*/
/*

Console.WriteLine("Num. 1/5:");
string line1 = Console.ReadLine();
float a = float.Parse(line1);
Console.WriteLine("Num. 2/5:");
string line2 = Console.ReadLine();
float b = float.Parse(line2);
Console.WriteLine("Num. 3/5:");
string line3 = Console.ReadLine();
float c = float.Parse(line3);
Console.WriteLine("Num. 4/5:");
string line4 = Console.ReadLine();
float d = float.Parse(line4);
Console.WriteLine("Num. 5/5:");
string line5 = Console.ReadLine();
float e = float.Parse(line5);

float sum = a + b + c + d + e;
float div = sum / 5;

Console.WriteLine("Average:" + div);
*/
/*

Console.WriteLine("Kör sugara:");
string line = Console.ReadLine();
float rad = float.Parse(line);

Console.WriteLine("Mértékegység:");
string line2 = Console.ReadLine();

double radius = rad * 2 * Math.PI;
double area = Math.Pow(rad, 2) * Math.PI;
//double area = rad * rad * Math.PI;

Console.WriteLine("Kör kerülete: " + radius + line2);
Console.WriteLine("Kör területe: " + area + line2);

*/
/*

Console.WriteLine("Num. 1/2:");
string line = Console.ReadLine();
float a = float.Parse(line);

Console.WriteLine("Num. 2/2:");
string line2 = Console.ReadLine();
float b = float.Parse(line2);

if(a < b)
{
    Console.WriteLine("Kisebb szám: " + a);
}
else
{
    Console.WriteLine("Kisebb szám: " + b);
}
if (a > b)
{
    Console.WriteLine("Nagyobb szám: " + a);
}
else
{
    Console.WriteLine("Nagyobb szám: " + b);
}

*/
/*

// Beolvasás
Console.WriteLine("Insert Number 1!");
string line1 = Console.ReadLine();
int number1 = int.Parse(line1);

Console.WriteLine("Insert Number 2!");
string line2 = Console.ReadLine();
int number2 = int.Parse(line2);

// Számítások elvégzése
int min;
int max;

if (number1 > number2)
{
    min = number2;
    max = number1;
}
else
{
    min = number1;
    max = number2;
}

// Kiíratás
Console.WriteLine("Minimum: " + min);
Console.WriteLine("Maximum: " + max);

*/

/*

Console.WriteLine("Base number: ");
string line1 = Console.ReadLine();
int baseNumber = int.Parse(line1);

Console.WriteLine("Exponent: ");
string line2 = Console.ReadLine();
int exp = int.Parse(line2);

double result = Math.Pow(baseNumber, exp);

Console.WriteLine("Result: " + result);

*/
/*
 
Console.WriteLine("Whole Num.: ");
string line = Console.ReadLine();
int num = int.Parse(line);


for (int i = 1;i <= num; i++)
{

    bool fizz = i % 3 == 0;
    bool buzz = i % 5 == 0;

    if (fizz && buzz)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (fizz)
    {
        Console.WriteLine("Fizz");
    }
    else if (buzz)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}

*/


Console.WriteLine("Pos X: ");
string line1 = Console.ReadLine();
float dx = float.Parse(line1);

Console.WriteLine("Pos Y: ");
string line2 = Console.ReadLine();
float dy = float.Parse(line2);

Console.WriteLine("Speed (m/s): ");
string line3 = Console.ReadLine();
float enemySpeed = float.Parse(line3);

float enemyDistance = (dx * dx) + (dy * dy);
float distance = (float) Math.Sqrt(enemyDistance);

float timeToReach = distance / enemySpeed;

Console.WriteLine("Time: " + timeToReach + "s");



