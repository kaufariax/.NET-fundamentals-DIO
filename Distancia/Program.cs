using System;

class Distancia {
  static void Main() {
    Console.WriteLine("Insira os quilômetros de distância: ");
    int quilometros = Int32.Parse(Console.ReadLine());
    int minutos = quilometros * 2;
    
    Console.WriteLine("levará " + minutos + " minutos para a moto Y tomar essa distância da outra moto ");
  }
}
