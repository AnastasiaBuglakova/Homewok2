// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа. 456 -> 5    782 -> 8   918 -> 1
/*
Console.Write("Please, input a three-digit number: ");
int a = Convert.ToInt32(Console.ReadLine());
int CutNumber(int arg)
{
arg = (a - (a / 100) * 100 - a % 10) / 10;
return arg;
}
int result = CutNumber(a);
Console.WriteLine(result);
*/
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.  645 -> 5    78 -> третьей цифры нет   32679 -> 6

/*
int LightThirdNum(int a)
{
    int razr = 1;
    while (a >= razr)
        razr = razr * 10;
    int a1 = ((a * 100 / razr) * (razr / 100));
    int a2 = a % (razr / 1000);
    a = (a - a1 - a2)/ (razr/1000);
    return a;
}
int Number = new Random().Next(-1, 100000);
if(Number>99)
{
    int Result = LightThirdNum(Number);
    Console.WriteLine($"Третья цифра справа из цифры {Number} - это {Result}!");
}
else 
    Console.WriteLine("третьей цифры нет");
    */

// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да    7 -> да     1 -> нет

Console.WriteLine("Please, enter number of week day from 1 to 7");
int number = Convert.ToInt32(Console.ReadLine());
bool FindWeekend(int n1)
{
bool weekday = true;
if(n1 == 1 || n1 == 2 || n1 == 3 || n1 == 4 || n1 == 5) weekday = false;
return weekday;
}
bool result = FindWeekend(number);
if(result == false) Console.WriteLine("Нет");
else Console.WriteLine("Да");