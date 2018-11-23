using System;

/*
  Dar entrada a enteros y almacenarlos en un arreglo de 5*4 y realizar lo
  siguiente: calcular la suma por renglón, la suma por columna,
  la suma total de la tabla y finalmente determinar el
  mayor de los números indicando la posición donde se encuentra (subíndices).
*/
class EjercicioD {

  int[,] matriz = new int[5, 4];

  public static void Main(String[] args) {
    EjercicioD d = new EjercicioD();
    d.randomizar();
    d.mostrar();
    Console.WriteLine();
    d.mostrarSumaRenglon();
    d.mostrarSumaColumna();
    d.mostrarSumaTotal();
    d.mostrarNumeroMayor();

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

  private void mostrarSumaRenglon() {
    int[] sumas = new int[matriz.GetLength(0)]; //renglones

    for(int i = 0; i < matriz.GetLength(0); i++) { //por cada renglón.
      for(int j = 0; j < matriz.GetLength(1); j++) { //cada columna
        sumas[i] += matriz[i, j];
      }
      Console.WriteLine("La suma del renglón {0} es: {1}", i, sumas[i]);
    }
  }

  private void mostrarSumaColumna() {
    int[] sumas = new int[matriz.GetLength(1)];

    for(int i = 0; i < matriz.GetLength(1); i++) { //por cada columna,
      for(int j = 0; j < matriz.GetLength(0); j++) { //por cada renglón.
        sumas[i] += matriz[j, i];
      }
      Console.WriteLine("La suma de la columna {0} es: {1}", i, sumas[i]);
    }
  }

  private void mostrarSumaTotal() {
    int suma = 0;
    for(int i = 0; i < matriz.GetLength(0); i++) {
      for(int j = 0; j < matriz.GetLength(1); j++) {
        suma += matriz[i, j];
      }
    }

    Console.WriteLine("La suma total es: {0}", suma);
  }

  private void mostrarNumeroMayor() {
    int numeroMayor = matriz[0, 0];
    int[] coordenadas = new int[2];

    for(int i = 0; i < matriz.GetLength(0); i++) {
      for(int j = 0; j < matriz.GetLength(1); j++) {
        if(matriz[i, j] > numeroMayor) {
          numeroMayor = matriz[i, j];
          coordenadas = new int[]{i, j};
        }
      }
    }

    Console.WriteLine("El número más grande fue: {0} en las coordenadas ({1}, {2}).", numeroMayor, coordenadas[0], coordenadas[1]);
  }
}
