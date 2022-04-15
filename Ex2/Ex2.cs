using System;

class Exercicio2
{
    public static void Main(string[] args)
    {
        double raio, area;
        double pi = 3.14159;

        raio = int.Parse(Console.ReadLine());
        area = (pi * raio * raio);

        Console.WriteLine($"{area:F4}");
    }
}