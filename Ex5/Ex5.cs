using System;

class Program
{
    public static void Main(string[] args)
    {
        int codigopeca1 = Convert.ToInt32(Console.ReadLine());
        int npeca1 = Convert.ToInt32(Console.ReadLine());
        float valorpeca1 = Single.Parse(Console.ReadLine());

        int codigopeca2 = Convert.ToInt32(Console.ReadLine());
        int npeca2 = Convert.ToInt32(Console.ReadLine());
        float valorpeca2 = Single.Parse(Console.ReadLine());

        float valor_total = (valorpeca1 * npeca1) + (valorpeca2 * npeca2);
        Console.WriteLine("VALOR TOTAL A PAGAR: ");
        Console.WriteLine(valor_total);
    }
}