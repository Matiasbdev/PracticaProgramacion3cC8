namespace Programa07;

class Program
{
    static void Main(string[] args)
    {
        // --- CONSTANTES DE CÁLCULO Y CONTROL ---
            const decimal TASA_IVA = 0.21m; // 21% fijo
            const bool MODO_PRUEBA = false; // Control de seguridad
            const char SIMBOLO_PESO = '$';

            Console.WriteLine("--- MÓDULO DE FACTURACIÓN ---");
            Console.WriteLine("Modo prueba activo: " + MODO_PRUEBA);

            decimal precioBase = 1500.50m;
            decimal impuestoCalculado = precioBase * TASA_IVA;
            decimal total = precioBase + impuestoCalculado;

            Console.WriteLine("\nDetalle de la compra:");
            Console.WriteLine("Precio: " + SIMBOLO_PESO + precioBase);
            Console.WriteLine("IVA (" + (TASA_IVA * 100) + "%): " + SIMBOLO_PESO + impuestoCalculado);
            Console.WriteLine("TOTAL A PAGAR: " + SIMBOLO_PESO + total);

            Console.ReadLine();



//---------------------HORAS DELDIA----------------------------------------

const int HORAS_DIA = 24;

        int dias = 3;
        int horasTotales = dias * HORAS_DIA;
        Console.WriteLine("3 días = " + horasTotales + " horas");



//---------------------CANTIDAD DE INTENTOS-------------------------------

 const int MAX_INTENTOS = 3;
    const int INTENTOS_USUARIO = 2;

        Console.WriteLine("Intentos máximos: " + MAX_INTENTOS);
        Console.WriteLine("Intentos realizados: " + INTENTOS_USUARIO);
        Console.WriteLine("¿Puede seguir intentando?: " + (INTENTOS_USUARIO < MAX_INTENTOS));




     //--------------------CALCULO SUELDO------------------


     const double SUELDO_BASE = 50000;
    const double BONO = 0.10;

    
        double salarioFinal = SUELDO_BASE + (SUELDO_BASE * BONO);
        Console.WriteLine("Salario final: $" + salarioFinal);
    

//---------------------MAXIMO DE PERSONAS-----------------------
 const int CAPACIDAD_MAX = 50;
    const int PERSONAS_ACTUALES = 45;


        Console.WriteLine("Capacidad máxima: " + CAPACIDAD_MAX);
        Console.WriteLine("Personas actuales: " + PERSONAS_ACTUALES);
        Console.WriteLine("¿Hay lugar disponible?: " + (PERSONAS_ACTUALES < CAPACIDAD_MAX));


//----------------------NOTA MINIMA----------------------------------------


const int NOTA_MINIMA = 6;
    const int NOTA_ESTUDIANTE = 8;


        Console.WriteLine("Nota mínima: " + NOTA_MINIMA);
        Console.WriteLine("Nota del estudiante: " + NOTA_ESTUDIANTE);
        Console.WriteLine("¿Aprobado?: " + (NOTA_ESTUDIANTE >= NOTA_MINIMA));


    }




    }
