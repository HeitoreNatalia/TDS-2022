using System;

class Exercicio4 {
  public static void Main (string[] args) {
    int num, horas;
    float sal;

    num = int.Parse(Console.ReadLine());
    horas = int.Parse(Console.ReadLine());
    sal = int.Parse(Console.ReadLine());

    sal = (sal*horas);
    
    Console.WriteLine ($"NÚMERO = {num}");
    Console.WriteLine ($"SALÁRIO = {sal:F2}");
  }
}