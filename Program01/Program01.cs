namespace Program01;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- SISTEMA DE REGISTRO DE USUARIO ---");

        // 1. Entrada de Texto (Simple)
        Console.Write("Por favor, ingresa tu nombre: ");
        string nombre = Console.ReadLine();

        // 2. Entrada de Números (Requiere Conversión)
        Console.Write("Ingresa tu edad: ");
        string edadTexto = Console.ReadLine();
        int edad = int.Parse(edadTexto); // Convertimos el texto a número entero

        // 3. Entrada de Decimales (Precios o Medidas)
        Console.Write("Ingresa tu estatura (ejemplo: 1,75): ");
        double estatura = double.Parse(Console.ReadLine()); // Conversión directa en una línea

        // 4. Mostrar los resultados procesados
        Console.WriteLine("\n--- PERFIL CREADO ---");
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Edad el próximo año: " + (edad + 1)); // Operación matemática
        Console.WriteLine("Estatura: " + estatura + " metros");

        Console.WriteLine("\nPresiona ENTER para seguir.");

//-----------------------------------------------------------------------------------------------------------------
        Console.WriteLine("Ahora ingresa tu apellido:");
        string apellido = Console.ReadLine();

        //Ingreso de email
        Console.WriteLine("Ingresa tu Email");
        string email = Console.ReadLine();

        //Ciudad en la que vive
        Console.WriteLine("Por favor,Ingresa la ciudad en que vives:");
        string ciudad = Console.ReadLine();

        //Codigo Postal
        Console.WriteLine("ingresa el codigo poastal de tu ciudad:");
        string codigoPostal = Console.ReadLine();
        int codigoPostal = int.Parse(codigoPostal);

        //
        Console.WriteLine("\n--- Perfil Actualizado ---");
        Console.WriteLine("Apellido:" + apellido);
        Console.WriteLine("Email:" + email);
        Console.WriteLine("Ciudad:" + ciudad);
        Console.WriteLine("Codio Postal" + codigoPostal);
//---------------------------------------------------------------------------------------------------------------------


Console.WriteLine("Ahora Continuemos:");

Console.WriteLine("agrega tu mes de Cumpleaños");
string mesCumple = Console.ReadLine();

//Dia de cumpleaños
Console.WriteLine("ahora el dia de tu cumple");
string diaCumple = Console.ReadLine();
int diaCumple = int.Parse(diaCumple);

Console.WriteLine("Por Ultimo ingresa el año en que naciste");
string añoNacimiento = Console.ReadLine();
int añoNAcimiento = int.Parse(añoNacimiento);


Console.WriteLine("---Datos Agregamos Correctamente---");
Console.WriteLine("Naciste el:"+ diaCumple + mesCumple + añoNacimiento);

//--------------------------------------------------------------------------------------------------------------------

Console.WriteLine("---Ahora cuentanos un poco acerca de tu familia---");

Console.WriteLine("Ingresa el Primer nombre de tu Madre");
string nombreMadre = Console.ReadLine();

Console.WriteLine("Ingresa el Apellido de soltera de tu Madre");
string apelliMadre = Console.ReadLine();

Console.WriteLine("Ahora el PrimerNombre de tu Padre");
string nombrePadre = Console.ReadLine();

Console.WriteLine("El apellido de tu Padre");
string apellidoPadre = Console.ReadLine();


Console.WriteLine("---TODO GUARDADO CON EXITO");
Console.WriteLine("tu Madre se llama: "+ nombreMadre + apelliMadre);
Console.WriteLine("Tu padre se llama:" + nombrePadre + apellidoPadre);

//-----------------------------------------------------------------------------------------------------------------------

Console.WtiteLine("---EL NOMBRE DE TUS HIJOS---");


Console.WriteLine("ingresa el nombre de tu Primer Hijo");
string nombreHijo1 = Console.ReadLine();

Console.WriteLine("Ingresa el nombre de tu segundo hijo");
string nombreHijo2 = Console.ReadLline();

Console.WriteLine(" ingresa el Nombre de tu tercer Hijo");
string nombreHijo3 = Console.ReadLine();


Console.WriteLine("---AGREGASTE CON EXITO EL NOMBRE DE TUS HIJOS");
Console.WriteLine("tu primer Hijo se llama:" + nombreHijo1 + apellido);
Console.WriteLine("Tu segundo hijo se llama" + nombreHijo2 + apellido);
Console.WriteLine("Tu tercer hijo se llama" + nombreHijo3 + apellido);

//------------------------------------------------------------------------------------------------------------------------

onsole.WriteLine("---POR ULTIMO AGREGUEMOS LAS EDADES DE TUS HIJOS---");

Console.WriteLine("Ingresa la edad de tu Primer Hijo");
string edadHijo1 = Console.ReadLine();
string edadHijo1 = int.Parse(edadHijo1);

Console.WriteLine("Ingresa la edad de tu segundo hijo");
string edadHijo2 = Console.ReadLine();
string edadHijo2 = int.Parse(edadHijo2);


Console.WriteLine("Ahora la edad de tu Tercer Hijo");
string edadHijo3 = Console.ReadLine();
string edadHijo3 = int.Parse(edadHijo3);



Console.WriteLine("---TODO GUARDADO CON EXITO");
Console.WriteLine("Tu primer Hijo: "+ nombreHijo1 + apellido + "t");
Console.WriteLine("Tu padre se llama:" + nombrePadre + apellidoPadre);

    }
}