Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n >=100 && n<=999)
{
    int i = n%10;
    Console.Write(i);
}
else
{
    Console.WriteLine("Введи ТРЕХзначное число! ");
}