// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
int namber = Convert.ToInt32(Console.ReadLine());
int namber1 = Convert.ToInt32(Console.ReadLine());
int max;
int min;
if (namber > namber1)
{
    max = namber;
    min = namber1;
}
else { 
        
        max = namber1;
        min = namber;
}
Console.WriteLine($"Больше:{max} меньше:{min}");
*/
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
int namber = Convert.ToInt32(Console.ReadLine());
int namber1 = Convert.ToInt32(Console.ReadLine());
int namber2 = Convert.ToInt32(Console.ReadLine());
int max;
if (namber > namber1)
{
    max = namber;

}
else if (namber1 > namber2)
{
    max = namber1;
}
else 
    max = namber2;

Console.WriteLine(max);
*/
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
int namber = Convert.ToInt32(Console.ReadLine());

if (namber % 2 == 0)
{
    Console.WriteLine($"Чётное:{namber}");


}
else Console.WriteLine($"Нечётное:{namber}");
*/
//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
int N = Convert.ToInt32(Console.ReadLine());

for (int a = 1; a <= N; a++) 
{ 
    if (a % 2 == 0)

        Console.WriteLine(a);
 
}
*/