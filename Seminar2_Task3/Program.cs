// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет является ли этот день выходным
Console.Write("Введите цифру (день недели) от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 6 || num == 7)
{
    Console.WriteLine("Этот день выходной");
}
else
{
    if (num<1 || num>7)
    {
        Console.WriteLine("Цифра введена не корректно");
    }
    else
    {
        Console.WriteLine("Это будний день");
    }
}
