using Calculate;
using System;
Cal cal = new Cal();
while (true)
{
    Console.WriteLine("Введите число для первого значения");
    string FirstInput = Console.ReadLine();
    int num1 = int.Parse(FirstInput);
    Console.WriteLine("Введите число для второго значения");
    string SecondInput = Console.ReadLine();
    int num2 = int.Parse(SecondInput);
    Console.WriteLine("Введите операцию: \n+\n-\n/\n*");
    string ChoseInput = Console.ReadLine();

    if (ChoseInput == "+")
    {
        Console.WriteLine(cal.addition(num1, num2));
    }
    else if (ChoseInput == "-")
    {
        Console.WriteLine(cal.subtraction(num1, num2));
    }
    else if (ChoseInput == "/")
    {
        Console.WriteLine(cal.division(num1, num2));
    }
    else if (ChoseInput == "*")
    {
        Console.WriteLine(cal.multiplication(num1, num2));
    }

    Console.WriteLine("Хотите закончить программу?(да, нет)");
    string Chose = Console.ReadLine();
    if (Chose == "1")
    {
        break;
    }
    else if (Chose == "2")
    {
        continue;
    }
}

