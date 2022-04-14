//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 1)
    Console.WriteLine("Введено некорректное число");
else
{
    int i = 1;
    bool Flag = true;
    while (i < N)
    {
        if ((i % 2) == 0)
            if (Flag == true)
            {
                Console.Write($"{i}");
                Flag = false;
            }    
            else
                Console.Write($", {i}");
        i += 1;
    }
    if ((i % 2) == 0)
        Console.Write($", {i}");
}