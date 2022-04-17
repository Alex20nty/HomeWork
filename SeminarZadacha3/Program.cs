
int a = 5;
int b = 35;

if(a==0)
{
    Console.WriteLine("a=0");
}
else
{
    if(b%a==0)
    {
        Console.WriteLine(b+ " кратно "+a);
    }
    else {
        Console.WriteLine(b%a);
    }
}
