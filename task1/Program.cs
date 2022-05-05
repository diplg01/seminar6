// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

int []mass = new int[10];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(0, 100);
    Console.Write(mass[i] + " ");
}
Console.WriteLine();

int save = 0;
for (int i = 0; i < mass.Length/2; i++)
{                                                // операция обмена двух переменных
    save = mass[i];
    mass[i] = mass[mass.Length-1-i];
    mass[mass.Length-1-i] = save;
}

for (int i = 0; i < mass.Length; i++)
{
    Console.Write(mass[i] + " ");
}
Console.WriteLine();
