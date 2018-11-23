using System;

/*
 * Dar entrada a enteros y almacenarlos en una tabla
 * de 3*3 e imprimir la traspuesta.
 */
class EjercicioC {

  private int[,] matriz = new int[3, 3];

  public static void Main(string[] args) {
    EjercicioC c = new EjercicioC();
    //c.randomizar();
    c.capturar();
    c.mostrar();
    Console.WriteLine();
    c.mostrarTraspuesta();

    Console.ReadLine();
  }

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
  }

  private void mostrarTraspuesta() {
    for(int i = 0; i < matriz.GetLength(0); i++) {
      for(int j = 0; j < matriz.GetLength(1); j++) {
        Console.Write("{0} ", matriz[j, i]);
      }
      Console.WriteLine();
    }
  }
}
