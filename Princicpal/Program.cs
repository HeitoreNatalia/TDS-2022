using System;

class Exercicio1 {   
    int a, b, soma;

    a = int.Parse(Console.ReadLine());
    b = int.Parse(Console.ReadLine());
    soma = a + b;

    Console.WriteLine(soma);
}


class Exercicio2 {
    double raio, area;
    double pi = 3.14159;
    
    raio = int.Parse(Console.ReadLine());
    area = (pi*raio*raio);
    
  Console.WriteLine ($"{area:F4}");
}


class Exercicio3 {
    int a, b, c, d, dif;

     a = int.Parse(Console.ReadLine());
     b = int.Parse(Console.ReadLine());
     c = int.Parse(Console.ReadLine());
     d = int.Parse(Console.ReadLine());
  
      dif = (a*b - c*d);
    
    Console.WriteLine ($"DIFERENCA: {dif}");
}


class Exercicio4 {
    int num, horas;
    float sal;

    num = int.Parse(Console.ReadLine());
    horas = int.Parse(Console.ReadLine());
    sal = int.Parse(Console.ReadLine());

    sal = (sal*horas);
    
    Console.WriteLine ($"NÚMERO = {num}");
    Console.WriteLine ($"SALÁRIO = {sal:F2}");
}


class Program
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


class Program
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


namespace Princicpal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto principal");
            Console.WriteLine("------------------------------");         
        }
    }
}
