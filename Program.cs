// Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void Palindrom(int num)
{
    if(num >= 10000 & num < 100000)
    {
        int sym1 = num / 10000;
        int sym5 = num % 10;
 
        if(sym1 == sym5)
            {
                num = num / 10;
                int sym2 = (num / 100) % 10;
                int sym4 = num % 10;
                if(sym2 == sym4) Console.WriteLine("Данное число является палиндромом");
            }
        else Console.WriteLine("Данное число не является палиндромом");
            
    }
    else Console.WriteLine("Неверно введено число, необходимо было ввести целое пятизначное число");
}
try
{ 
    Console.WriteLine("Введите пятизначное число:");
    int num = int.Parse(Console.ReadLine()!);
    Palindrom(num);
}
catch
{
    Console.WriteLine("Неверно введено число, необходимо было ввести целое пятизначное число цифрами");
}