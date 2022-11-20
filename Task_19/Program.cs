// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите число:   ");
string number = (Console.ReadLine());
int length = number.Length;
string txtToCheck = number.Replace(" ","");  

bool IsPalindrome()
{
    for (int i = 0; i < length / 2; i++)
        while (number[i] == number[length - 1])
        {
            return true;
        }
    return false;
}

if (IsPalindrome()) System.Console.WriteLine($"Да, число - {number} - является палиндромом");
else System.Console.WriteLine($"Нет, число {number} не является палиндромом");
System.Console.WriteLine();