// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Summa(int M, int N)
{
    int start = M;
    int end = N;
    
    if(M>N)
    {
        start = N;
        end = M;
    }
    
    return (end+start)*(end - start +1)/2;
}




//--------------основной код--------------


int M = ReadInt("Введите первое число: ");
int N = ReadInt("Введите второе число: ");

Summa(M,N);
System.Console.WriteLine(Summa(M,N));

