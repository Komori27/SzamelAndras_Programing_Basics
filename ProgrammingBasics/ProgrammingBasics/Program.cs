/*
Console.WriteLine("Hello World");

//komment
// komment

int age = 21;
Console.WriteLine(age);
age = 22;
Console.WriteLine(age);

int height; // declaration
height= 178; // definition
Console.WriteLine(height);

int abc = age + 5 + height - 3;
Console.WriteLine(abc);
Console.WriteLine(age+5);

int a, b, c;

a = 5;
b = 7;
c = a + b;
c = 25;
Console.WriteLine(c);

// műveletek
int sum = a + b;  // 12
int dif = a - b; // -2
int product = a * b; // 35
int rate = a / b; // 0

int modulo1 = 10 % 3;   // 1
int modulo2 = 12 % 4;   // 0
int modulo3 = 6 % 5;    // 1
int modulo4 = 100 % 8;  // 4
int modulo5 = 12 % 16;  // 12

int num1 = 3 + 2 * 4;   // 11
int num2 = (3 + 2) * 4; // 20

int number = 0;

number = number + 5; // 5          //
number += 5;         // 10         //same as previous (shorter ver.)
number -= 2;         // 8
number *= 2;         // 16
number /= 3;         // 5   16/3 = 5  (- maradék)
number %= 3;         // 2   5/3 = 1 -> maradék = 2

number += 1;         // 3
number++;            // 4
number--;            // 3

// ----------------------------------------------------

int i1 = 12;           //32 bit
long l1 = 12;          //64 bit
float f1 = 12.5f;      //32 bit 
double d1 = 12.77;     //64 bit double az alap, nem kell "f" a végére

float f2 = 12.45f;
float f3 = 3 + f2;

// Casting / kasztolás

int i2 = 7;
float f4 = 33.5f;

int i3 = (int) f4;   //casting - konvertálás int ből float ba (vagy vissza)    //explicit kasztolás (jelölni kell a kasztolást)
float f5 = i2;     // "(float)" elhagyható                                     //implicit kasztolás (nem kell jelölni)

// ---------------------------------------------------

string myString = "abc";

string s1 = "AAA" + "BBB";              //összefűzés -> AAABBB
Console.WriteLine(s1);

string s2 = f1 + "AAA" + i3 + "BBB";                //összefűzés -> AAABBB     /i3.ToString - kasztolás, implicit, fordítva nem működik (string to int/float/...)

string s3 = 3 + i1 + "AAA";             //műveleti sorrend balról jobbra -> szám + szám -> string = 15AAA

string s4 = "" + 3 + i1 + "AAA";       //műveleti sorrend -> string az első -> az egészet stringként veszi = 3i1AAA

int xxx = int.Parse("10");

xxx += 5;

int hex = 0x1A45F3B;
int bin = 0b10100101;

Console.WriteLine(xxx);

// --------------------------------------------------

bool b1 = false;
bool b2 = true;

bool b3 = i1 > f3;

Console.WriteLine(b3);

bool b4 = i1 < f3;
bool b5 = i1 >= f3;
bool b6 = i1 <= f3;

bool b9 = i1 == f3;     // == - egyenlőség vizsgálat / egyenlő-e
bool b10 = i1 != f3;    // != egyenlőtlenség vizsgálat / NEM egyenlő-e

bool b11 = "AAABBB" == "aaabbb";    //false
bool b12 = "AAABBB" == "AAABBB";    //true

// -----------------------------------------------------

bool b13 = b1 == b2;

bool b14 = b1 && b2;        //and - mindkettő igaz -> T
bool b15 = b1 || b2;        //or - az egyik igaz -> T

bool b16 = !b1;             //negálás - ha T akkor F, ha F akkor T

bool b17 = b1 ^ b2;         //xor - kizáró vagy / ha mindkettő ugyan az = F  (T+T=F, T+F=T, F+T=T, F+F=F)

*/