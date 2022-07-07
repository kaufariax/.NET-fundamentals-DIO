using System;

class Mandioca {
  static void Main() {
    
    Console.WriteLine("Digite quantas porções vai querer Chico: ");
    var chico = 300 * Int32.Parse(Console.ReadLine());

    Console.WriteLine("Digite quantas porções vai querer Bento: ");
    var bento = 1500 * Int32.Parse(Console.ReadLine());

    Console.WriteLine("Digite quantas porções vai querer Bernardo: ");
    var bernardo = 600 * Int32.Parse(Console.ReadLine());

    Console.WriteLine("Digite quantas porções vai querer Marina: ");
    var marina = 1000 * Int32.Parse(Console.ReadLine());

    Console.WriteLine("Digite quantas porções vai querer Iara: ");
    var iara = 150 * Int32.Parse(Console.ReadLine());

    var marlene = 225;
    var total = chico + bento + bernardo + marina + iara + marlene;
    
    Console.WriteLine("Marlene, você vai precisar preparar " + total + " gramas de mandioca!");
  }
}