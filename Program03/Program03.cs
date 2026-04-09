namespace Programa03;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- BLOQUE 2: NÚMEROS CON DECIMALES ---");

            // Estatura (double)
            double estatura = 1.75;
            Console.WriteLine("2. TIPO DECIMAL COMÚN (double):");
            Console.WriteLine("   Valor guardado: " + estatura + " metros");

            // Dinero (decimal) - Recuerda la 'm' al final
            decimal precioProducto = 199.99m;
            Console.WriteLine("\n3. TIPO DECIMAL FINANCIERO (decimal):");
            Console.WriteLine("   ¡Obligatorio para dinero! Usa la 'm'.");
            Console.WriteLine("   Valor guardado: $" + precioProducto);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

//--------------------SUMA DE DECIMALES---------------------------------------

 double a = 5.5;
        double b = 2.3;
        double suma = a + b;

        Console.WriteLine("La suma es: " + suma);






//-------------------DIVISION DE DECIMALES-----------------------------------

double x = 10.0;
        double y = 4.0;
        double division = x / y;

        Console.WriteLine("La división es: " + division);
    


//-------------------CALCULAR EL DESCUENTO------------------------------------

double precio = 250.0;
        double descuento = 0.15; // 15%

        double precioFinal = precio - (precio * descuento);

        Console.WriteLine("Precio final con descuento: " + precioFinal);


//-----------CALCULA EL AREA DE UN CIRCULO-------------------------------------

 double radio = 4.5;
        double area = Math.PI * Math.Pow(radio, 2);

        Console.WriteLine("El área del círculo es: " + area);



//----------CALCULA PRECIO CON IVA-----------------------------------------------

double precio = 100.0;
        double iva = 0.21; // 21%
        double precioFinal2 = precio + (precio * iva);

        Console.WriteLine("Precio final con IVA: " + precioFinal2);
    }
}