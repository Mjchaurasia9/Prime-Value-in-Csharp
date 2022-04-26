// See https://aka.ms/new-console-template for more information
int num1, num2, ch, i, j;
Console.WriteLine("Enter Value to check Prime Or Not");
Console.Write("Enter first Value:\t");
num1 = int.Parse(Console.ReadLine());
Console.Write("Enter Second Value:\t");
num2 = int.Parse(Console.ReadLine());
for (i = num1; i <= num2; i++)
{
ch = 0;
for ( j = 2; j <= i/2; j++)
{
if (i % j == 0)
{
ch++;
break;
}
}
if (ch == 0)
{
Console.Write(i+" ");
}
}
