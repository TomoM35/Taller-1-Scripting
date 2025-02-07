# Taller-1-Scripting



///////Preguntas del Taller////////


¿Qué es un error en tiempo de ejecución?
Es un error que ocurre mientras el programa se está ejecutando, provocando que se detenga inesperadamente o genere resultados incorrectos. Ocurre cuando el código intenta realizar una operación inválida, como dividir por cero.



¿Qué es un ciclo infinito? 
Un ciclo infinito es un bucle que nunca termina porque la condición de salida nunca se cumple.









 -void Saludar()
 {
       Console.WriteLine("¡Hola!");
 }
 // Invocación
 Saludar();

-void ImprimirNumero(int numero)
 {
       Console.WriteLine("Número: " + numero);
 }
  // Invocación
 ImprimirNumero(5);


 -int ObtenerNumero()
 {
       return 10; 
 }
 int resultado = ObtenerNumero();

 -void Sumar(int a,int b)
 {
       Console.WriteLine(a + b);
 }
 // Invocación
 Sumar(3, 7);

 -int Multiplicar(int a,int b)
 {
       return a * b;
 }
 int resultado = Multiplicar(4, 5);


-void MostrarmeMensaje(string mensaje)
{
       Console.WriteLine(mensaje);
}
MostrarMensaje("Hola Mundo");

-void MostrarMatriz(int[,] matriz)
{
    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            Console.Write(matriz[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] matriz = { { 1, 2 }, { 3, 4 } };
MostrarMatriz(matriz);

-class Persona
{
    public string Nombre;
}

-void SaludarPersona(Persona p)
{
    Console.WriteLine("Hola, " + p.Nombre);
}
Persona persona = new Persona() { Nombre = "Juan" };
SaludarPersona(persona);


-bool EsMayorDeEdad(int edad)
{
    return edad >= 18;
}
bool esAdulto = EsMayorDeEdad(20);


-void ImprimirLista(List<String> lista)
{
      foreach (var item in lista)
      {
           Console.WriteLine(item);
      }
}
Lits<string> lista = new List<string>() {"Manzana", "Pera","Platano"};
ImprimirLista(lista);


-string SaludarConNombre(string nombre)
{
      return "Hola   " + nombre;
}
string saludo = SaludarConNombre("Carlos");

-void ImprimirCaracter(Char c)
{
    Console.WriteLine(c);
}
Imprimircaracter("A");

-void ImprimirBienvenida()
{
   Console.WriteLine("Bienvenido al sistema");
}
ImprimirBienvenida();


-void ImprimirArea(double radio)
{
   double area = Math.PI * radio * radio;
   Console.WriteLine("Área:  " + area );
}
ImprimirArea(5.5);


-void Saludar(string nombre = "Invitadp")
{
   Console.WriteLine("Hola" + nombre);
}
Saludar();
Saludar("Ana");

-void int Factorial(int n)
 {
        if (n == 0) return 1;
        return n * Factorial(n - 1);
 } 
 int resultado = Factorial(5);

 -void DuplicarValor(ref int x)
 {
       x = x * 2;
 }
 int num = 5;
 DuplicarValor(ref num);

 (int, string) ObtenerDatos()
 {
      return(42,"Respuesta");
 }
 var datos = ObtenerDatos();
 Console.WriteLine($"Número: {datos.Item1}, Texto:{datos.Item2}");

 -void Operar(int a,int b, char operacion)
 {
          if (operacion =="+")
          {
          ConsoleWriteLine(a + b);
 }
 Operar(5,3,"+")

 -void Dividir(int a, int b, out int resultado)
 {
         if (b != 0)
         {
            resultado = a/ b; 
         }
         else 
         {
              resultado = 0; 
         }
}
int res; 
Dividir (10,2, out res);
