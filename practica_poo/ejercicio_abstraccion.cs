using System;
using System.Collections.Generic;
using System.Linq;

// ======================== CLASES DE PRODUCTOS ========================

public abstract class Producto
{
    public string Codigo { get; set; }
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public int Stock { get; set; }

    protected Producto(string codigo, string nombre, decimal precio, int stock)
    {
        Codigo = codigo;
        Nombre = nombre;
        Precio = precio;
        Stock = stock;
    }

    public abstract string ObtenerDescripcion();
}

public class ProductoElectronico : Producto
{
    public int GarantiaMeses { get; set; }

    public ProductoElectronico(string codigo, string nombre, decimal precio, int stock, int garantiaMeses)
        : base(codigo, nombre, precio, stock)
    {
        GarantiaMeses = garantiaMeses;
    }

    public override string ObtenerDescripcion()
    {
        return $"{Nombre} (Electrónico) - Código: {Codigo}, Precio: {Precio:C}, Stock: {Stock}, Garantía: {GarantiaMeses} meses";
    }
}

public class ProductoAlimento : Producto
{
    public DateTime FechaVencimiento { get; set; }

    public ProductoAlimento(string codigo, string nombre, decimal precio, int stock, DateTime fechaVencimiento)
        : base(codigo, nombre, precio, stock)
    {
        FechaVencimiento = fechaVencimiento;
    }

    public bool EstaVencido()
    {
        return DateTime.Today > FechaVencimiento;
    }

    public override string ObtenerDescripcion()
    {
        string estado = EstaVencido() ? "VENCIDO" : "Vigente";
        return $"{Nombre} (Alimento) - Código: {Codigo}, Precio: {Precio:C}, Stock: {Stock}, Vence: {FechaVencimiento.ToShortDateString()} ({estado})";
    }
}

public class ProductoRopa : Producto
{
    public string Talle { get; set; }
    public string Color { get; set; }

    public ProductoRopa(string codigo, string nombre, decimal precio, int stock, string talle, string color)
        : base(codigo, nombre, precio, stock)
    {
        Talle = talle;
        Color = color;
    }

    public override string ObtenerDescripcion()
    {
        return $"{Nombre} (Ropa) - Código: {Codigo}, Precio: {Precio:C}, Stock: {Stock}, Talle: {Talle}, Color: {Color}";
    }
}

// ======================== INVENTARIO GENÉRICO ========================

public class Inventario<T> where T : Producto
{
    private readonly Dictionary<string, T> _productos = new Dictionary<string, T>();

    // Agregar producto sin duplicados por código
    public void Agregar(T producto)
    {
        if (_productos.ContainsKey(producto.Codigo))
            Console.WriteLine($"Error: Ya existe un producto con el código {producto.Codigo}.");
        else
        {
            _productos.Add(producto.Codigo, producto);
            Console.WriteLine($"Producto {producto.Nombre} agregado correctamente.");
        }
    }

    // Búsqueda parcial por nombre (insensible a mayúsculas/minúsculas)
    public List<T> BuscarPorNombre(string textoBusqueda)
    {
        return _productos.Values
            .Where(p => p.Nombre.Contains(textoBusqueda, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    // Filtra productos con stock menor o igual al mínimo especificado
    public List<T> FiltrarPorStockMinimo(int stockMinimo)
    {
        return _productos.Values
            .Where(p => p.Stock <= stockMinimo)
            .ToList();
    }

    // Calcula el valor total del inventario (suma de precio * stock)
    public decimal CalcularValorTotal()
    {
        return _productos.Values.Sum(p => p.Precio * p.Stock);
    }

    // Método adicional para mostrar todo el inventario (útil para demostración)
    public void MostrarInventario()
    {
        Console.WriteLine("\n--- Inventario Completo ---");
        foreach (var p in _productos.Values)
        {
            Console.WriteLine(p.ObtenerDescripcion());
        }
        Console.WriteLine($"Valor total del inventario: {CalcularValorTotal():C}\n");
    }
}

// ======================== PROGRAMA DE DEMOSTRACIÓN ========================

class Program
{
    static void Main()
    {
        // Creamos un inventario que puede contener cualquier tipo derivado de Producto
        Inventario<Producto> inventario = new Inventario<Producto>();

        // Creación de productos de los tres tipos
        var telefono = new ProductoElectronico("E001", "Smartphone XYZ", 15000m, 10, 12);
        var leche = new ProductoAlimento("A001", "Leche Entera", 800m, 25, new DateTime(2025, 4, 15));
        var camisa = new ProductoRopa("R001", "Camisa de Lino", 2500m, 5, "M", "Azul");

        // Agregar al inventario
        Console.WriteLine("=== AGREGANDO PRODUCTOS ===");
        inventario.Agregar(telefono);
        inventario.Agregar(leche);
        inventario.Agregar(camisa);

        // Intento de agregar duplicado (mismo código)
        var telefonoDuplicado = new ProductoElectronico("E001", "Otro Teléfono", 10000m, 3, 6);
        Console.WriteLine("\n--- Prueba de duplicado ---");
        inventario.Agregar(telefonoDuplicado);

        // Mostrar inventario completo
        inventario.MostrarInventario();

        // Búsqueda por nombre parcial
        Console.WriteLine("=== BÚSQUEDA POR NOMBRE (parcial) ===");
        string busqueda = "leche";
        var encontrados = inventario.BuscarPorNombre(busqueda);
        Console.WriteLine($"Resultados para '{busqueda}':");
        foreach (var p in encontrados)
            Console.WriteLine(p.ObtenerDescripcion());

        // Filtrar por stock mínimo (stock <= 5)
        Console.WriteLine("\n=== FILTRAR POR STOCK MÍNIMO (stock <= 5) ===");
        var stockBajo = inventario.FiltrarPorStockMinimo(5);
        foreach (var p in stockBajo)
            Console.WriteLine(p.ObtenerDescripcion());

        // Mostrar valor total
        Console.WriteLine($"\n=== VALOR TOTAL DEL INVENTARIO ===\n{inventario.CalcularValorTotal():C}");

        // Demostración extra: mostrar si un alimento está vencido (accediendo a propiedad específica)
        var alimento = inventario.BuscarPorNombre("Leche").FirstOrDefault() as ProductoAlimento;
        if (alimento != null)
        {
            Console.WriteLine($"\nEstado del alimento '{alimento.Nombre}': {(alimento.EstaVencido() ? "Vencido" : "No vencido")}");
        }
    }
}