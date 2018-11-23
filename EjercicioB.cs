using System;

/* Dar entrada a enteros y almacenarlos en una tabla 
de 3 * 4, imprimir el renglon 2 y la columna 3.
*/
class EjercicioB {

  int[, ] matriz = new int[3, 4];

  public static void Main(string[] args) {
    EjercicioB b = new EjercicioB();
    //b.randomizar();
    b.capturar();
    b.mostrar();
    Console.WriteLine();
    b.mostrarEjercicio();
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

  private void mostrarEjercicio() {
    //por cada columna
    for(int i = 0; i < matriz.GetLength(1); i++) {
      Console.Write("{0} ", matriz[2, i]);
    }
    Console.WriteLine();
    //por cada renglón
    for(int i = 0; i < matriz.GetLength(0); i++) {
      Console.Write("{0} ", matriz[i, 3]);
    }
  }
}
