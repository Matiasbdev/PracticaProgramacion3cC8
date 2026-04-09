namespace Programa06;

class Program
{
    static void Main(string[] args)
    {
        // --- CONSTANTES DE IDENTIDAD Y REGLAS ---
            const string NOMBRE_APP = "GameMaster Pro";
            const string VERSION = "v1.0.2";
            const int EDAD_MINIMA = 18;

            Console.WriteLine("=== " + NOMBRE_APP + " (" + VERSION + ") ===");
            Console.WriteLine("Cargando reglas del sistema...");
            Console.WriteLine("Restricción: Prohibida la venta a menores de " + EDAD_MINIMA + " años.");
            
            // Intento de uso con constantes (sin estructuras de control)
            const int EDAD_CLIENTE = 20;
            const bool PUEDE_INGRESAR = EDAD_CLIENTE >= EDAD_MINIMA; // expresión booleana

            Console.WriteLine("\nVerificando cliente de " + EDAD_CLIENTE + " años...");
            Console.WriteLine("Edad mínima: " + EDAD_MINIMA);
            Console.WriteLine("Acceso permitido (valor bool constante): " + PUEDE_INGRESAR);

            // Mostrar constantes para reforzar concepto
            Console.WriteLine("Constante NOMBRE_APP = " + NOMBRE_APP);
            Console.WriteLine("Constante VERSION = " + VERSION);

            Console.ReadLine();


        //-------- JUEGO-------------------------

const string JUEGO = "KING OF FIGHTERS";
    const int EDAD_MINIMA = 16;
    const int EDAD_USUARIO = 14;

        Console.WriteLine("Juego: " + JUEGO);
        Console.WriteLine("Edad mínima requerida: " + EDAD_MINIMA);
        Console.WriteLine("Edad del usuario: " + EDAD_USUARIO);
        Console.WriteLine("Acceso permitido: " + (EDAD_USUARIO >= EDAD_MINIMA));


//------------------PRODUCTO CON IVA--------------------------

const string PRODUCTO = "Netbook Gamer";
    const double PRECIO_BASE = 1200.50;
    const double IVA = 0.21;

    static void Main() {
        double precioFinal = PRECIO_BASE + (PRECIO_BASE * IVA);
        Console.WriteLine("Producto: " + PRODUCTO);
        Console.WriteLine("Precio base: $" + PRECIO_BASE);
        Console.WriteLine("Precio final con IVA: $" + precioFinal);
    


//----------------BIBLIOTECA---------------------------------------

const string BIBLIOTECA = "Biblioteca municipal";
    const int LIBROS_TOTALES = 50000;
    const int MAX_PRESTAMOS = 3;


        Console.WriteLine("Bienvenido a " + BIBLIOTECA);
        Console.WriteLine("Cantidad de libros disponibles: " + LIBROS_TOTALES);
        Console.WriteLine("Máximo de préstamos por usuario: " + MAX_PRESTAMOS);


//---------------CONEXION---------------------------------------------


const string NOMBRE_SERVIDOR = "ServidorCentral";
    const string IP = "192.168.1.10";
    const int PUERTO = 8080;

    
        Console.WriteLine("Conectando a " + NOMBRE_SERVIDOR);
        Console.WriteLine("IP: " + IP);
        Console.WriteLine("Puerto: " + PUERTO);


//------------------------APLICACION-----------------------------------------------

 const string NOMBRE_APLICACION = "MusicPlayer X";
    const string VERSION = "2.5.1";
    const string AUTOR = "Matías Dev";

        Console.WriteLine("=== " + NOMBRE_APLICACION+ " (" + VERSION + ") ===");
        Console.WriteLine("Desarrollado por: " + AUTOR);




    }
    }
}
