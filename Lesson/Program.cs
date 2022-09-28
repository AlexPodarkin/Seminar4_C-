Console.Clear();
/* Console.Write("Введите число:");
int limit = int.Parse(Console.ReadLine());
int GetSumToLimit(int limit)
{    int result = 0;
    for (int i = 0; i <= limit; i++)
    {        result += i;    }
    return result;
}
Console.WriteLine($"Результат суммы от 1 до {limit} = {GetSumToLimit(limit)}"); */



/* Console.Write("Введите число:");
int num = int.Parse(Console.ReadLine());
int count = 1;
while (num > 10)
{
    num /=10;
    count++;
}
Console.WriteLine($"Количество цифр в числе = {count}"); */


int Metod(int num)
{
    int count = 1;
    while (num > 10)
    {
        num /= 10;
        count++;
    }
    return count;
}


int result = Metod(12365);
Console.WriteLine($"Количество цифр в числе = {result}");
int resul = Metod(1236);
Console.WriteLine($"Количество цифр в числе = {resul}");
int resu = Metod(5);
Console.WriteLine($"Количество цифр в числе = {resu}"); 



/* Console.Write("Введите число:");
int limit = int.Parse(Console.ReadLine());

int GetSumToLimit(int limit)
{
    int result = 0;
    for (int i = 0; i <= limit; i++) { result++; }
    return result;
}
Console.WriteLine($"result summ 1 to {limit} = {GetSumToLimit(limit)}"); */







