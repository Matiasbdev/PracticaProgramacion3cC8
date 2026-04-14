namespace EjercicioArrays3
{
    internal class Program
    {
        static void Main (string [] args)
        {
        
            Console.WriteLine ("Ejercicio 1");
            int [] edades = {15,10,22,30};
            int CantidadElementos = edades.Length;
            Console.WriteLine("Cantidad de elementos:" + CantidadElementos);
            for (int i= 0; i < edades.Length; i++)
            {
                Console.WriteLine("indice:" + i + "edad: " + edades[i]);
            }


            //-----------Ejercicio 2--------------------
            Console.WriteLine("Ejercicio 2");
            double [] precios = {9.99, 19.99, 29.99, 39.99};
            int cantidadPrecios = precios.Length;
            Console.WriteLine("Cantidad de elementos:" + cantidadPrecios);
            for (int i=0; i < precios.Length; i++)
            {
                Console.WriteLine("índice: " + i + "precio: " + precios [i]);
            }


            //------------------------Ejercicio 3---------------
            Console.WriteLine("Ejercicio 3");
            string [] nombres = {"Juan", "María", "Pedro", "Ana"};
            int cantidadNombres = nombres.Length;
            Console.WriteLine ("Cantidad de elementos: " + cantidadNombres);
            for (int i=0; i < nombres.Length ; i++)
            {
                Console.WriteLine("índice: " + i + "nombre: " + nombres [i]);
            }

            //------------------Ejercicio 4---------------
            Console.WriteLine("Ejercicio 4");
            char [] letras = {'A', 'B', 'C', 'D'};
            int cantidadLetras = letras.Length;
            Console.WriteLine("Cantidad de elementos: " + cantidadLetras);
            for (int i=0; i < letras.Length; i++)
            {
                Console.WriteLine ("índice: " + i + "Letra: " +letras[i] );
            }
            

            //-----------------------Ejercicio 5-------------------
            Console.WriteLine("Ejercicio 5");
            bool [] respuestas = {true, false};
            int CantidadRespuestas = respuestas.Length;
            Console.WriteLine("Cantidad de elementos: " + CantidadRespuestas);
            for (int i=0; i<respuestas.Length; i++)
            {
                Console.WriteLine("indice: " + i + "respuesta: " + respuestas[i]);
            }

         

        }
    }
}