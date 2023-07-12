// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Akkerman(int M, int N)
{
    if(M == 0) return N + 1;
    if(M > 0 && N ==0) return Akkerman(M-1,1);
    else return Akkerman(M-1, Akkerman(M,N-1));
}

//--------------основной код--------------


int M = ReadInt("Введите первое положительное целое число: ");
int N = ReadInt("Введите второе положительное целое число: ");
System.Console.WriteLine($"Число Аккермана равно {Akkerman(M,N)}");