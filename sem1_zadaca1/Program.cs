// программa, которая принимает на вход два числа и выдаёт максимальное из этих чисел. 
Console.WriteLine("Введите два числа");
int a, b;
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());

if(a>b)
{
    Console.WriteLine("{0} наибольшее число", a);
}
else
{
    Console.WriteLine("{0} наибольшее число", b);
}
