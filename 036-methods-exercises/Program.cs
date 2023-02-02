//** Lukas Larndorfer
//** Exercises until Level 4
string selection;
int NullZähler = 0;
int EinsZähler = 0;
int ZweiZähler = 0;
int number = 0;
int ersteZahl = 0;
int zweiteZahl = 1;
int nextNumber;
int index = 0;
int input = 0;
int max = 10;
int min = 5;
do
{
    Console.Clear();
    Console.WriteLine("Welches Programm willst du ausführen?");
    Console.WriteLine("============================");
    Console.WriteLine();
    Console.WriteLine("0. Calculate Circle Area");
    Console.WriteLine("1. Random in Range");
    Console.WriteLine("2. To FizzBuzz");
    Console.WriteLine("3. Fibonacci by Index");
    Console.WriteLine("4. Ask for Number in Range");
    Console.WriteLine("5. Is palindrome?");
    Console.WriteLine("6. Is palindrome? (advanced)");
    Console.WriteLine("7. Chart Bar");
    Console.WriteLine("8. Count Smiling Faces");
    Console.WriteLine("q to Quit");
    selection = Console.ReadLine()!;


    if (selection != "q")
    {
        Console.Clear();
        switch (selection)
        {
            case "0":
                RunCalculateCircleArea();
                break;

            case "1":
                RunRandomInRange();
                break;

            case "2":
                RunToFizzBuzz();
                break;

            case "3":
                RunFibonacciByIndex();
                break;

            case "4":
                RunAskForNumberInRange();
                break;


            default:
                break;
        }

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}
while (selection != "q");
#region Calculate Circle Area
void RunCalculateCircleArea()
{
    Console.Write("Enter radius:");
    var radius = double.Parse(Console.ReadLine()!);
    var area = CalculateCircleArea(radius);
    Console.WriteLine($"Area of circle with radius {radius} is {area}");
}

double CalculateCircleArea(double radius)
{
    return radius * radius * Math.PI;
}
#endregion

int RandomInRange(int min, int max)
{
    int random = Random.Shared.Next(min, max + 1);
    return random;
}
void RunRandomInRange()
{

    for (int i = 0; i <= 100000; ++i)
    {
        int random = RandomInRange(0, 2);
        switch (random)
        {
            case 0:
                NullZähler++;
                break;

            case 1:
                EinsZähler++;
                break;

            case 2:
                ZweiZähler++;
                break;
        }
    }

    System.Console.WriteLine($"zero{NullZähler}, one{EinsZähler}, two{ZweiZähler}");
}

string ToFizzBuzz(int number)
{
    string FizzBuzz = "";

    if (number % 3 == 0 && number % 5 == 0)
    {
        FizzBuzz = "FizzBuzz";
    }
    else if (number % 3 == 0)
    {
        FizzBuzz = "Fizz";
    }
    else if (number % 5 == 0)
    {
        FizzBuzz = "Buzz";
    }
    else { FizzBuzz = $"{number}"; }

    return FizzBuzz;
}
void RunToFizzBuzz()
{
    System.Console.WriteLine("Enter a number ");
    number = int.Parse(Console.ReadLine()!);
    System.Console.WriteLine(ToFizzBuzz(number));
}

int FibonacciByIndex(int index)
{
    {
        Console.WriteLine("Enter the index to Print: ");
        index = int.Parse(Console.ReadLine()!);
        if (index < 2)
        {
            Console.WriteLine("Please Enter a number greater than two");
        }
        else
        {
            Console.Write(ersteZahl + " " + zweiteZahl + " ");

            for (int i = 2; i < index; i++)
            {
                nextNumber = ersteZahl + zweiteZahl;
                Console.WriteLine(nextNumber + " ");
                ersteZahl = zweiteZahl;
                zweiteZahl = nextNumber;
            }
        }
    }
    return ersteZahl;
}
void RunFibonacciByIndex()
{
    System.Console.WriteLine(FibonacciByIndex(index));
}

int AskForNumberInRange(int min, int max)
{
    do
    {
        System.Console.WriteLine("Please enter a value between 5 and 10");
        input = int.Parse(Console.ReadLine()!);

        if (input > max)
        {
            System.Console.WriteLine("Wrong number. Your input is too high. The maximum is 10. Try again!");
        }
        else if (input < min)
        {
            System.Console.WriteLine("Wrong number. Your input is too low. The minimum is 5. Try again!");
        }
        else if (input! < min && input! > max)
        {
            System.Console.WriteLine("Thank you, your input is valid.");
        }
    }
    while (input! < min && input! > max);
    return input;
}
void RunAskForNumberInRange()
{
    System.Console.WriteLine(AskForNumberInRange(max, min));
}


