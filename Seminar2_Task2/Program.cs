// Напишите программу которая выводит третью цифру заданного числа или сообщает, что цифры нет
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string num1 = Convert.ToString(num);

if (num > 99) 
{
    Console.WriteLine(num1[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
