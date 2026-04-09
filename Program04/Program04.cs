namespace Programa04;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- BLOQUE 3: TEXTO Y CARACTERES ---");

            // Cadena de texto (string) - Comillas dobles ""
            string nombre = "Ana López";
            Console.WriteLine("4. TIPO TEXTO (string):");
            Console.WriteLine("   Valor guardado: " + nombre);

            // Carácter único (char) - Comillas simples ''
            char inicialNombre = 'A';
            Console.WriteLine("\n5. TIPO CARÁCTER (char):");
            Console.WriteLine("   Valor guardado: '" + inicialNombre + "'");

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();



//---------------NOMBRE Y APELLIDO CON STRING---------------------

string nombre = "Matias";
        string apellido = "Burgos";
        Console.WriteLine("Nombre completo: " + nombre + " " + apellido);



//-------------------CONTAR LETRAS-------------------------------

string palabra = "Practicas";
        Console.WriteLine("La palabra '" + palabra + "' tiene " + palabra.Length + " letras.");



//--------------------CAMBIAR UNA FRASE----------------------------

string frase = "Me gusta C#";
        string nuevaFrase = frase.Replace("C#", "JAVASCRIPT");
        Console.WriteLine("Original: " + frase);
        Console.WriteLine("Modificada: " + nuevaFrase);


//-----------------EJEMPLOS CON CHAR--------------------------------
char letra = 'B';
        Console.WriteLine("Carácter guardado: " + letra);



//--------------PASAR A MAYUSCULA-----------------------

char letra = 'c';
        Console.WriteLine("Original: " + letra);
        Console.WriteLine("Mayúscula: " + Char.ToUpper(letra));
    }
}