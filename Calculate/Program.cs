using System;
using Calculate;
using Calculate.Math;

Cal cal = new Cal();
Calculator calculator = new Calculator(); 
while (true)
{
    Console.WriteLine("Введите первое число");
    string FirstInput = Console.ReadLine();
    int num1 = int.Parse(FirstInput);
    Console.WriteLine("Введите второе число");
    string SecondInput = Console.ReadLine();
    int num2 = int.Parse(SecondInput);
    Console.WriteLine("Введите операцию (+,-,*,/)");
    string Symbol = Console.ReadLine();
    if (Symbol == "+")
    {
        Console.WriteLine(cal.addition(num1, num2));
    }
    else if (Symbol == "-")
    {
        Console.WriteLine(cal.subtraction(num1, num2));
    }
    else if (Symbol == "*")
    {
        Console.WriteLine(cal.multiplication(num1, num2));
    }
    else if (Symbol == "/")
    {
        Console.WriteLine(cal.division(num1, num2));
    }

    Console.WriteLine("Хотите ли вы завершить работу?");
    string choose = Console.ReadLine();
    if (choose == "да")
    {
        Console.WriteLine("Хотите ли вы попробовать другой калькулятор?");
        string chose = Console.ReadLine();
        if (chose == "да")
        {
            Console.WriteLine("Введите число:");
            string Input = Console.ReadLine();
            int num3 = int.Parse(Input);
            Console.WriteLine("Выберите операцию(1 - возведение в квадрат, 2 - возведение в куб, 3 - корень числа, 4 - косинус, 5 - синус, 6 - тангенц, 7 - выход");
            string Math = Console.ReadLine();
            if (Math == "1")
            {
                Console.WriteLine(calculator.Exponentiation2(num3));
            }
            else if (Math == "2")
            {
                Console.WriteLine(calculator.Exponentiation3(num3));
            }
            else if (Math == "3")
            {
                Console.WriteLine(calculator.Root(num3));
            }
            else if (Math == "4")
            {
                Console.WriteLine(calculator.Cos(num3));
            }
            else if (Math == "5")
            {
                Console.WriteLine(calculator.Sin(num3));
            }
            else if (Math == "6")
            {
                Console.WriteLine(calculator.Tan(num3));
            }
            else if (Math == "7")
            {
                break;
            }
        }
        else
        {
            break;
        }
    }
    else
    {
        continue;
    }
}