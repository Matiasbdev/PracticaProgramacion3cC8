using System;
using System.Collections.Generic;

// Clase base abstracta
public abstract class Empleado
{
    public string Nombre { get; set; }
    public int Legajo { get; set; }
    public decimal SueldoBase { get; set; }

    protected Empleado(string nombre, int legajo, decimal sueldoBase)
    {
        Nombre = nombre;
        Legajo = legajo;
        SueldoBase = sueldoBase;
    }

    // Método para calcular el sueldo mensual
    public abstract decimal CalcularSueldoMensual();

    // Método para mostrar información 
    public virtual void MostrarInfo()
    {
        Console.WriteLine($"Nombre: {Nombre}, Legajo: {Legajo}, Sueldo Base: {SueldoBase:C}");
    }
}

// Empleado de tiempo completo: recibe bono anual prorrateado
public class EmpleadoTiempoCompleto : Empleado
{
    private const decimal BonoAnual = 50000m;
    private const int MesesAnio = 12;

    public EmpleadoTiempoCompleto(string nombre, int legajo, decimal sueldoBase)
        : base(nombre, legajo, sueldoBase)
    {
    }

    public override decimal CalcularSueldoMensual()
    {
        decimal bonoMensual = BonoAnual / MesesAnio;
        return SueldoBase + bonoMensual;
    }

    public override void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine($"Tipo: Tiempo Completo, Sueldo Mensual: {CalcularSueldoMensual():C}");
        Console.WriteLine("---");
    }
}

// Empleado part-time: trabaja X horas (sin sueldo base fijo)
public class EmpleadoPartTime : Empleado
{
    public int HorasMes { get; set; }
    public decimal ValorHora { get; set; }

    public EmpleadoPartTime(string nombre, int legajo, int horasMes, decimal valorHora)
        : base(nombre, legajo, 0)  // sin tiene sueldo base
    {
        HorasMes = horasMes;
        ValorHora = valorHora;
    }

    public override decimal CalcularSueldoMensual()
    {
        return HorasMes * ValorHora;
    }

    public override void MostrarInfo()
    {
        Console.WriteLine($"Nombre: {Nombre}, Legajo: {Legajo}, Tipo: Part-Time");
        Console.WriteLine($"Horas/mes: {HorasMes}, Valor por hora: {ValorHora:C}, Sueldo Mensual: {CalcularSueldoMensual():C}");
        Console.WriteLine("---");
    }
}

// Empleado contratado: contrato eventual, no recibe bono
public class EmpleadoContratado : Empleado
{
    public DateTime FechaVencimiento { get; set; }

    public EmpleadoContratado(string nombre, int legajo, decimal sueldoBase, DateTime fechaVencimiento)
        : base(nombre, legajo, sueldoBase)
    {
        FechaVencimiento = fechaVencimiento;
    }

    public override decimal CalcularSueldoMensual()
    {
        // sueldo base, sin bono
        return SueldoBase;
    }

    public int DiasParaVencimiento()
    {
        return (FechaVencimiento - DateTime.Today).Days;
    }

    public override void MostrarInfo()
    {
        base.MostrarInfo();
        int dias = DiasParaVencimiento();
        string estadoVencimiento = dias >= 0 ? $"Faltan {dias} días" : "Contrato vencido";
        Console.WriteLine($"Tipo: Contratado, Fecha de vencimiento: {FechaVencimiento.ToShortDateString()}, {estadoVencimiento}");
        Console.WriteLine($"Sueldo Mensual: {CalcularSueldoMensual():C}");
        Console.WriteLine("---");
    }
}

// Programa principal
class Program
{
    static void Main()
    {
        // Lista de empleados de diferentes tipos
        List<Empleado> empleados = new List<Empleado>
        {
            new EmpleadoTiempoCompleto("Ana López", 1001, 2500m),
            new EmpleadoPartTime("Carlos Pérez", 1002, 80, 15.5m),
            new EmpleadoContratado("Lucía Gómez", 1003, 2000m, new DateTime(2026, 12, 31)),
            new EmpleadoTiempoCompleto("Roberto Ruiz", 1004, 2800m),
            new EmpleadoPartTime("Marta Díaz", 1005, 60, 18m),
            new EmpleadoContratado("Jorge Fernández", 1006, 2200m, new DateTime(2025, 3, 15))
        };

        Console.WriteLine("=== INFORMACIÓN DE EMPLEADOS ===\n");
        decimal totalNomina = 0;

        foreach (var emp in empleados)
        {
            emp.MostrarInfo();
            totalNomina += emp.CalcularSueldoMensual();
        }

        Console.WriteLine($"\n=== COSTO TOTAL DE NÓMINA MENSUAL ===\n{totalNomina:C}");
    }
}