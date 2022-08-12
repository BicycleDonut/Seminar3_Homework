// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите число:   ");
int N = Convert.ToInt32(Console.ReadLine());
N = Math.Abs(N);
string s = Convert.ToString(N);
int first = int.Parse(s[0].ToString());
int second = int.Parse(s[1].ToString());
int fourth = int.Parse(s[3].ToString());
int fifth = int.Parse(s[4].ToString());
if (first == fifth && second == fourth)
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}


