// Напишите программу, которая принимает на вход число (N) и выдаёт
// таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Ведите любое число N:  ");
int N = Convert.ToInt32(Console.ReadLine());
N = Math.Abs(N);
int count = 1;
if (N == 0)
{
    Console.WriteLine("0");
}
else
{
    while (count <= N)
    {
        Console.WriteLine(Math.Pow(count, 3));
        count++;
    }
}
