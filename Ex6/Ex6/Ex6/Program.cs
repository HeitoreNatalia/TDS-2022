using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("");
        float a = Convert.ToSingle(Console.ReadLine());
        Console.Write("");
        float b = Convert.ToSingle(Console.ReadLine());
        Console.Write("");
        float c = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("TRIANGULO: " + (a * c) / 2);
        Console.WriteLine("CIRCULO: " + (c * c) * 3.14159);
        Console.WriteLine("TRAPEZIO: " + ((a + b) / 2) * c);
        Console.WriteLine("QUADRADO: " + (b * b));
        Console.WriteLine("RETANGULO: " + a * b);
        Console.ReadLine();

    }
}