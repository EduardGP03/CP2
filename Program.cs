using System.Diagnostics;

static void SayHello() => Console.WriteLine("Hello, World! ");

static void IntMin_IntMax()
{
    Console.WriteLine($"El minimo valor de int es: {int.MinValue} \n El maximo valor de int es: {int.MaxValue} ");
}

static void PI() => Console.WriteLine("Valor aproximado de PI: " + Math.PI);

static void MwdioLimon()
{
    Console.WriteLine("Introduzca su cadena: ");
    
    string line = Console.ReadLine();

    Console.WriteLine("La cadena de texto con medio limon al final es: " + line + " medio limon. ");
}

static void Double()
{
    Console.WriteLine("Entre un numero entero: ");

    int number = int.Parse(Console.ReadLine());

    Console.WriteLine($"El doble del numero es {number * 2}");
}

static void Min_Max()
{
    Console.WriteLine("Introduce dos numeros enteros: ");

    int number1 = int.Parse(Console.ReadLine());
    int number2 = int.Parse(Console.ReadLine());

    int min = (-Math.Abs(number1 - number2) + number1 + number2) / 2;

    Console.WriteLine(min);

    int max = (Math.Abs(number1 - number2) + number1 + number2) / 2;

    Console.WriteLine(max);
}

static void Middle_Average()
{
    Console.WriteLine("Introduzca tres numeros enteros: ");

    int number1 = int.Parse(Console.ReadLine());
    int number2 = int.Parse(Console.ReadLine());
    int number3 = int.Parse(Console.ReadLine());

    int center = Math.Max(Math.Min(number1, number2), Math.Min(Math.Max(number1, number2), number3));

    Console.WriteLine("El valor del centro es: {0}", center);

    double average = (number1 + number2 + number3) / 3.0;

    Console.WriteLine($"El promedio es: {average} ");
}

static void Character()
{
    Console.WriteLine("Introduzca una cadena: ");
    string line = Console.ReadLine();

    Console.WriteLine("Introduzca un numero entero menor que la longitud de la cadena: ");
    int number1 = int.Parse(Console.ReadLine());

    char character = line[number1];

    Console.WriteLine($"La letra de la posision {number1} es: {character}");
}

static void ExchangeVariables_1()
{
    Console.WriteLine("Introduzca el numero 1: ");
    int number1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Introduzca el numero 2: ");
    int number2 = int.Parse(Console.ReadLine());

    int auxiliary = number1;
    number1 = number2;
    number2 = auxiliary;

    Console.WriteLine($"El numero 1 es: {number1} \n El numero 2 es: {number2} ");
}

static void ExchangeVariables_2()
{
    Console.WriteLine("Introduzca el numero 1: ");
    int number1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Introduzca el numero 2: ");
    int number2 = int.Parse(Console.ReadLine());

    number1 = number1 + number2;
    number2 = number1 - number2;
    number1 = number1 - number2;

    Console.WriteLine($"El numero 1 es: {number1} \n El numero 2 es: {number2} ");
}

static void Circle()
{
    Console.WriteLine("Introduzca el radio de la circunferencia: ");

    float radio = float.Parse(Console.ReadLine());

    float area = (float)(Math.Pow(radio, 2) * (4 * Math.PI - 3 * Math.Sqrt(3)) / 3);

    Console.WriteLine($"El valor del area sombreada es {area}");
}

static void QuadraticEquation()
{
    Console.WriteLine("Introduzca los coeficientes de una ecuacion cuadratica: ");

    int number1 = int.Parse(Console.ReadLine());
    int number2 = int.Parse(Console.ReadLine());
    int number3 = int.Parse(Console.ReadLine());
    double D = Math.Pow(number2, 2) - (4 * number1 * number3);

    double solution1 = (-number2 - Math.Sqrt(D)) / (2 * number1);
    double solution2 = (-number2 + Math.Sqrt(D)) / (2 * number1);
    Console.WriteLine($"Solucion1: {solution1} \n Solucion2: {solution2} ");
}

static void WritingSpeed_1()
{
    Console.WriteLine("Introduzca un texto para ver que tiempo demora en hacerlo: ");

    Stopwatch crono = new Stopwatch();
    Console.WriteLine("Introduzca un texto para ver que tiempo demora en hacerlo: ");
    crono.Start();
    string text = Console.ReadLine();
    crono.Stop();

    double speed = text.Length / crono.ElapsedMilliseconds / 1000.0;

    Console.WriteLine($"El tiempo en segundos que te demoraste en escribir el texto fue: {speed} s ");
}

static void WritingSpeed_2()
{
    Console.WriteLine("Introduzca un texto para ver que tiempo demora en hacerlo: ");

    long start = Environment.TickCount;
    string text = Console.ReadLine();
    long end = Environment.TickCount;
    double speed = text.Length / (end - start) / 1000.0;

    Console.WriteLine($"El tiempo en segundos que te demoraste en escribir el texto fue: {speed} s ");
}

static void DateOfBirth()
{
    Console.WriteLine("Introduzca su ID: ");
    long cd = long.Parse(Console.ReadLine());

    int year = (int)(cd / Math.Pow(10, 9));
    cd = (long)(cd % Math.Pow(10, 9));

    int month = (int)(cd / Math.Pow(10, 7));
    cd = (long)(cd % Math.Pow(10, 7));

    int day = (int)(Math.Pow(10, 5));

    Console.WriteLine($"{year}/{month}/{day}");
}













