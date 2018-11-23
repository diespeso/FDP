using System;

/*
El profesor de programación desea un algoritmo o programa que le permita
obtener los promedios para sus 20 alumnos.
El considera su número de control, nombre y 3 calificaciones parciales. 
Imprimir todos los datos.
*/
class EjercicioE {

  /* Lógica del programa: Cada alumno es representado con un número
   * del 1 al 20, y cada dato del alumno está almacenado en una array con
   * 20 espacios, así, acceder los datos del alumno 5 significaría acceder
   * a los datos de todas las arrays siguientes en el index 5.
   *
   * Dentro de capturar, en cada captura se calcula el promedio para que
   * esté listo a la hora de imprimir la información.
   */

   /*
    * Justificación: A lo largo del programa se no se usa hardcoding,
    * esto con el fin de poder cambiar la longitud de los arrays con
    * motivo de debug. La constante ALUMNOS no se usa en los ciclos,
    * y se usan en su lugar los métodos de array de CSharp.
    * Esto se hizo para poder copiar y pegar el código en caso de ser
    * necesario. Aunque sería mejor si se pasaran las array como parámetros,
    * así sería completamente reutilizable cada método.
    */

  //Modifícanos!
  const int ALUMNOS = 20;
  const int PARCIALES = 3;

  string[] nombres = new string[ALUMNOS];
  int[] matriculas = new int[ALUMNOS];
  //contiene 20 arrays de 3 parciales cada una.
  int[,] parciales = new int[ALUMNOS, PARCIALES];
  //contiene los promedios de cada alumno.
  int[] promedios = new int[ALUMNOS];

  public static void Main(string[] args) {
    EjercicioE e = new EjercicioE();
    e.randomizar();
    //e.capturar();
    Console.WriteLine();
    e.mostrar();
  }

  //Usar si se quiere hacer un test automático, sino usar capturar.
  Random random = new Random();
  private void randomizar() {
    int sumatoria = 0;
    for(int i = 0; i < nombres.Length; i++) {
      nombres[i] = "Alumno No." + i;
      matriculas[i] = random.Next(100000,111111);
      for(int j = 0; j < parciales.GetLength(1); j++) {
        parciales[i, j] = random.Next(11);
        sumatoria += parciales[i, j];
      }
      //divide la sumatoria entre el número de parciales.
      promedios[i] = sumatoria / parciales.GetLength(1);
      sumatoria = 0;
    }
  }

  private void capturar() {
    int sumatoria = 0;
    for(int i = 0; i < nombres.Length; i++) {
      Console.WriteLine("Captura No.{0}", i + 1);
      Console.Write("Nombre: ");
      nombres[i] = Console.ReadLine();

      Console.Write("Matrícula: ");
      matriculas[i] = System.Int32.Parse(Console.ReadLine());
      for(int j = 0; j < parciales.GetLength(1); j++) { //por cada parcial
        Console.Write("Parcial {0}: ", j);
        parciales[i, j] = System.Int32.Parse(Console.ReadLine());
        sumatoria += parciales[i, j];
      }
      promedios[i] = sumatoria / parciales.GetLength(1);
      sumatoria = 0;
    }
  }

  private void mostrar() {
    //Mustra los encabezados
    Console.WriteLine("Nombre\tMatrícula\tParciales\t\tPromedio");
    //Muestra el nombre y matrícula de cada alumno.
    for(int i = 0; i < nombres.GetLength(0); i++) {
      Console.Write("{0}\t{1}\t", nombres[i], matriculas[i]);
      //por cada alumno mostrar sus 3 parciales.
      for(int j = 0; j < parciales.GetLength(1); j++) {
        Console.Write(" \t{0}", parciales[i, j]);
      }
      //mostrar el promedio, por cada alumno.
      Console.Write("\t{0}", promedios[i]);
      Console.WriteLine();
    }
  }
}
