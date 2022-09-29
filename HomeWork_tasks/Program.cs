Console.Clear();

Console.Clear();
Console.Write("Enter tusk number:");
int num = Convert.ToInt32(Console.ReadLine());
switch (num)
{
    case 1:
        Console.WriteLine("Задача принимает два числа (A и B) \nи возводит число A в натуральную степень B.");
        Console.Write("Введите число A:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число B:");
        int b = Convert.ToInt32(Console.ReadLine());
        int result = 0;
        int Metod(double result)
        {
            result = Math.Pow(a, b);
            return Convert.ToInt32(result);
        }
        Console.WriteLine($"{Metod(result)}");
        break;

    case 2:

        Console.WriteLine("программa, которая принимает \nна вход число и выдаёт сумму цифр в числе");
        Console.Write("Введите число:"); //321
        int numSum = Convert.ToInt32(Console.ReadLine());
        int resSum = 0;
        int temp = 0;
        string len = Convert.ToString(numSum);
        int count = 1;
        while (count <= len.Length)
        {
            temp = numSum - numSum % 10;
            resSum = resSum + (numSum - temp);
            numSum /= 10;
            count++;
        }
        Console.WriteLine($"Otvet: {resSum}");
        break;
}







/* Console.Write("Введите число:"); //321
double num = Convert.ToInt32(Console.ReadLine());
double result = 0;
string len = Convert.ToString(num);
int count = 1;
while (count <= len.Length)
{
    Console.WriteLine($"                 Count - {count}");
    num = num % Math.Pow(10 , count);
    Console.WriteLine($"Chislo {num}");
    result+=num;
    count++;
}
Console.WriteLine($"Otvet: {result}"); //разобрать на семинаре ! */


