using System;

class CoxinhaDeBueno {
  static void Main() {
    Console.WriteLine("Insira a quantidade de coxinhas e participantes no seguinte formato: 'coxinhas participantes'");
    string[] line = Console.ReadLine().Split(" ");
    double coxinhas = int.Parse(line[0]);
    double participantes = int.Parse(line[1]);
    double media = coxinhas / participantes;
    
    Console.WriteLine(media.ToString("N1"));
  }
}
