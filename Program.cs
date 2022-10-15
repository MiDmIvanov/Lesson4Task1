// Напишите функцию, используя цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int Mult(int _A, int _B)
{
    int X = 1;
    for (int i = 1; i <= _B; i++)
    {
        X = X*_A;
    }
    return X;
}

int A = 0;
int B = 0;
Console.WriteLine("Введите число А:");
int.TryParse(Console.ReadLine()!, out A);
Console.WriteLine("Введите число B:");
int.TryParse(Console.ReadLine()!, out B);

Console.WriteLine($"{A} в степени {B} равно {Mult(A,B)}");

