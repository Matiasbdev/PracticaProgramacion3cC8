namespace Programa05;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- BLOQUE 4: VALORES LÓGICOS (SÍ / NO) ---");

            // Booleano (bool) - Solo true o false
            bool cursoCompletado = true;

            Console.WriteLine("6. TIPO LÓGICO (bool):");
            Console.WriteLine("   Solo puede ser 'true' o 'false'.");
            Console.WriteLine("   ¿El curso está completado?: " + cursoCompletado);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();


//--------------------ES MAYOR?-----------------------------------------
 bool Mayor = 10 > 5;   // true
        Console.WriteLine("¿10 es mayor que 5? " + Mayor);



 //-------------------PUEDE ENTRAR?------------------------------------   

bool esAdulto = true;
        bool tieneEntrada = false;

        bool puedeEntrar = esAdulto && tieneEntrada; 

        Console.WriteLine("¿Puede entrar? " + puedeEntrar);


//----------------------LUZ PRENDIDA-----------------------------------

bool luzPrendida = true;

Console.WriteLine("La luz esta prendida?"+ luzPrendida);


//---------------------SON IGUALES?------------------------------------

bool iguales =(7 == 7);
Console.WriteLline("Son iguales?" + iguales);


//--------------------DIFERENTES---------------------------------------

bool diferentes = (4 != 9);
Console.WriteLline("Son diferentes?" + diferentes);








    }
}