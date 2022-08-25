// Написать программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа
int num = new Random().Next(100, 1000);
Console.WriteLine(num);

int num1 = num/100;
int num2 = num - num1*100;
int num3 = num2/10;

Console.WriteLine(num3);
