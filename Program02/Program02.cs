namespace Programa02;

class Program
{
    static void Main(string[] args)
    {
            Console.WriteLine("--- BLOQUE 1: NÚMEROS ENTEROS ---");

            // Declaración de un entero
            int edad = 28;

            Console.WriteLine("1. TIPO ENTERO (int):");
            Console.WriteLine("   Para números sin decimales, como edad o cantidad.");
            Console.WriteLine("   Valor guardado: " + edad);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();


//------------------------SUMA DE ENTEROS---------------------------------------------------------

 int a = 5;
        int b = 7;
        int suma = a + b;

        Console.WriteLine("La suma es: " + suma);


  //    ------------------NUMERO PAR I IMPAR---------------------------------------------------
   int numero = 9;

        if (numero % 2 == 0)
            Console.WriteLine(numero + " es par");
        else
            Console.WriteLine(numero + " es impar");



 //------------NUMERO MAYOR---------------------------------------------------------------------

int x = 12, y = 25, z = 7;
        int mayor = x;

        if (y > mayor) mayor = y;
        if (z > mayor) mayor = z;

        Console.WriteLine("El mayor es: " + mayor);

//------------CUADRADO DE UN NUMERO-------------------------------------------------------------

  int numero = 6;
        int cuadrado = numero * numero;

        Console.WriteLine("El cuadrado de " + numero + " es: " + cuadrado);


 //------------FACTORIAL DE UN NUMERO-----------------------------------------------------------

  int n = 5;
        int factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        Console.WriteLine("El factorial de " + n + " es: " + factorial);       

    }
}
