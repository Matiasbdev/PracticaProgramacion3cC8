namespace EjercicioArrays2
{
    internal class Program
    {
        static void Main (string [] args)
        {
            // Eercicio 1
            Console.WriteLine("Ejercicio 1");
            string [] frutas = {"manzana", "banana", "naranja", "pera", "uva"};
            Console.WriteLine("Lista de Frutas con Foreach:");
            foreach (string fruta in frutas)
            {
                Console.WriteLine("Fruta: " +fruta);
            }
            //-------EJERCICIO 2-------------
            Console.WriteLine("ANIMALES");
            string [] animales = {"perro", "gato", "conejo", "pájaro"};
            Console.WriteLine("Lista de animales:");
            foreach (string animal in animales)
            {
                Console.WriteLine("Animal: " + animal);
            }

            //--------Ejercicio 3-----------------------
            onsole.WriteLine("Ejercicio 3");
            string [] hinchadas = {"River", "Boca", "San Martín", "Atletico"};
            Console.WriteLine("Las mejores hinchadas son:");
            foreach (string hinchada in hinchadas)
            {
                Console.WriteLine ("Hinchada:" + hinchada);
        }

        //-------------------------EJERCICIO 4--------------------------
        console.WriteLine("Ejercicio 4");
            string [] coloresPrimarios = {"rojo", "verde", "azul", "amarillo"};
            Console.WriteLine("Lectura con Foreach:");
            foreach (string color in coloresPrimarios)
            {
                Console.WriteLine("Color:" + color);
            }
//---------------------------------Ejercicio 5-------------------------
Console.WriteLine("Ejercicio ");
            string [] paises = {"Argentina", "Brasil", "Chile", "Peru"};
            Console.WriteLine("Impresión con foreach:");
            foreach (string pais in paises)
            {
                Console.WriteLine("País: " + pais);
            }
    }
}
}