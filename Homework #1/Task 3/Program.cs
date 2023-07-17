// Task 3: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Input the number");
int num1 = Convert.ToInt32(Console.ReadLine());
if(num1 % 2 == 0)
    Console.WriteLine("Yes");
    else
    Console.WriteLine("No");