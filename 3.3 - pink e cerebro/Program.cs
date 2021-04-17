﻿using System;

class Program {
  static void Main(string[] args) {
    int quantidade = int.Parse(Console.ReadLine());
    string numeros = Console.ReadLine();
    string[] lista = numeros.Split(' ');
    int div2 = 0;
    int div3 = 0;
    int div4 = 0;
    int div5 = 0;

    for ( int i = 0; i < quantidade; i++) {
      int n = int.Parse(lista[i]);
    
      if (n % 2 == 0) {
        div2 += 1;
      }
    
      if(n % 3 == 0) {
        div3 += 1;
      }
    
      if (n % 4 == 0) {
        div4 += 1;
      }
    
      if(n % 5 == 0) {
        div5 += 1;
      }
    }
    
    string result = "";
    result += $"{div2} Multiplo(s) de 2\n";
    result += $"{div3} Multiplo(s) de 3\n";
    result += $"{div4} Multiplo(s) de 4\n";
    result += $"{div5} Multiplo(s) de 5\n";
    Console.WriteLine(result.ToString());
  }
}