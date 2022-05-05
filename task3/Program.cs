// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
string resalt = string.Empty;
while (A > 0)
{
    resalt = A % 2 + resalt;
    A = A / 2;
}
Console.WriteLine(resalt);
