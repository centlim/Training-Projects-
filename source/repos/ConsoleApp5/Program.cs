// See https://aka.ms/new-console-template for more information


using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
double x;
double y;
double z;

Console.Write("1st Number : ");
x = Convert.ToDouble(Console.ReadLine());
Console.Write("2nd Number : ");
y = Convert.ToDouble(Console.ReadLine());
z = Multiply(x, y);
Console.WriteLine($"{x} * {y} = {z}");


static double Multiply(double x, double y)
{
    double z = x * y;
    return z;
}

