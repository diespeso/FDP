using System;

 /*Dar entrada a enteros y almacenarlos en una tabla
  de 4*4 e imprimir la diagonal principal*/ 
class EjercicioA {
  private int[,] matriz = new int[4, 4];

  Random random = new Random();
  private void randomizar() {
    for(int i = 0; i < matriz.GetLength(0); i++) {
      for(int j = 0; j < matriz.GetLength(1); j++) {
        matriz[i, j] = random.Next(10);
      }
    }
  }

  private void capturar() {
    for(int i = 0; i < matriz.GetLength(0); i++) {
      for(int j = 0; j < matriz.GetLength(1); j++) {
        matriz[i, j] = System.Int32.Parse(Console.ReadLine());
      }
    }
  }

  private void mostrar() {
    for(int i = 0; i < matriz.GetLength(0); i++) {
      for(int j = 0; j < matriz.GetLength(1); j++) {
        Console.Write("{0} ", matriz[i, j]);
      }
      Console.WriteLine();
    }

    Console.WriteLine();
  }

  private void mostrarDiagonalPrincipal() {
    for(int i = 0; i < matriz.GetLength(0); i++) {
      for(int j = 0; j < matriz.GetLength(1); j++) {
        if(i == j) {
          Console.Write("{0} ", matriz[i, j]);
        }
      }
    }
    Console.WriteLine();
  }

  public static void Main(string[] args) {
    EjercicioA a = new EjercicioA();
    a.randomizar();
    //a.capturar();
    a.mostrar();
    a.mostrarDiagonalPrincipal();

    Console.ReadLine();
  }

}
