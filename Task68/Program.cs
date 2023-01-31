/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/
Console.Clear();
int getDataFromUser(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
int m = getDataFromUser("Введите число M");
int n = getDataFromUser("Введите число N");

int akkerman (int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0)
    {
        return akkerman(m - 1, 1);
    }
        return akkerman(m - 1, akkerman(m, n - 1));
    
}
int result = akkerman(m, n);
Console.WriteLine($"{result}");