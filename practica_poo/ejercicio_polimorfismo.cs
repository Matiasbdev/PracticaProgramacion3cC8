using System;
using System.Collections.Generic;

// 1. Interfaz común
public interface INotificador
{
    void Enviar(string destinatario, string mensaje);
    int ObtenerCantidadEnviados();
    string ObtenerNombreCanal();
}

// 2. Implementaciones concretas con contador
public class NotificadorEmail : INotificador
{
    private int _mensajesEnviados = 0;

    public void Enviar(string destinatario, string mensaje)
    {
        // Simulación de envío real
        Console.WriteLine($"[Email] Para: {destinatario} - Mensaje: {mensaje}");
        _mensajesEnviados++;
    }

    public int ObtenerCantidadEnviados() => _mensajesEnviados;

    public string ObtenerNombreCanal() => "Email";
}

public class NotificadorSMS : INotificador
{
    private int _mensajesEnviados = 0;

    public void Enviar(string destinatario, string mensaje)
    {
        Console.WriteLine($"[SMS] A: {destinatario} - Texto: {mensaje}");
        _mensajesEnviados++;
    }

    public int ObtenerCantidadEnviados() => _mensajesEnviados;

    public string ObtenerNombreCanal() => "SMS";
}

public class NotificadorPush : INotificador
{
    private int _mensajesEnviados = 0;

    public void Enviar(string destinatario, string mensaje)
    {
        Console.WriteLine($"[Push] Usuario: {destinatario} - Contenido: {mensaje}");
        _mensajesEnviados++;
    }

    public int ObtenerCantidadEnviados() => _mensajesEnviados;

    public string ObtenerNombreCanal() => "Push";
}

// 3. Gestor que trabaja con la interfaz, sin conocer tipos concretos
public class GestorNotificaciones
{
    private readonly List<INotificador> _notificadores = new List<INotificador>();

    // Permite agregar cualquier notificador que implemente la interfaz
    public void AgregarNotificador(INotificador notificador)
    {
        _notificadores.Add(notificador);
    }

    // Envía el mensaje a todos los canales registrados
    public void NotificarATodos(string destinatario, string mensaje)
    {
        foreach (var notificador in _notificadores)
        {
            notificador.Enviar(destinatario, mensaje);
        }
    }

    // Genera el reporte de cantidad de mensajes por canal
    public void MostrarReporte()
    {
        Console.WriteLine("\n=== REPORTE DE MENSAJES ENVIADOS ===");
        foreach (var notificador in _notificadores)
        {
            Console.WriteLine($"{notificador.ObtenerNombreCanal()}: {notificador.ObtenerCantidadEnviados()} mensajes");
        }
    }
}

// 4. Programa de demostración
class Program
{
    static void Main()
    {
        // Crear gestor
        GestorNotificaciones gestor = new GestorNotificaciones();

        // Agregar canales existentes
        gestor.AgregarNotificador(new NotificadorEmail());
        gestor.AgregarNotificador(new NotificadorSMS());
        gestor.AgregarNotificador(new NotificadorPush());

        // Simular envíos
        Console.WriteLine("=== ENVIANDO NOTIFICACIONES ===\n");
        gestor.NotificarATodos("cliente@empresa.com", "Su factura está lista");
        gestor.NotificarATodos("+5491112345678", "Código de verificación: 123456");
        gestor.NotificarATodos("usuario123", "Tienes un nuevo mensaje");

        // Mostrar reporte final
        gestor.MostrarReporte();

        // Demostración de extensibilidad: agregar un nuevo canal sin modificar el Gestor
        // Supongamos un nuevo canal "WhatsApp"
        gestor.AgregarNotificador(new NotificadorWhatsApp()); // Definido abajo
        Console.WriteLine("\n--- Se agregó nuevo canal WhatsApp ---");
        gestor.NotificarATodos("contacto@ejemplo.com", "Mensaje de prueba con nuevo canal");
        gestor.MostrarReporte();
    }
}

// Ejemplo de nuevo canal que se puede agregar sin modificar GestorNotificaciones
public class NotificadorWhatsApp : INotificador
{
    private int _mensajesEnviados = 0;

    public void Enviar(string destinatario, string mensaje)
    {
        Console.WriteLine($"[WhatsApp] A: {destinatario} - Mensaje: {mensaje}");
        _mensajesEnviados++;
    }

    public int ObtenerCantidadEnviados() => _mensajesEnviados;

    public string ObtenerNombreCanal() => "WhatsApp";
}