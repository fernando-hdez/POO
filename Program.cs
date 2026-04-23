using System;
using System.Security.Cryptography;

namespace Name
{
public class Empleado
    {
        public string nombre;
        public int edad;
        public int salario;
        public int antiguedad;

        public Empleado(string nombre, int edad, int salario, int antiguedad)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.salario = salario;
            this.antiguedad = antiguedad;
        }

    public void mostrarDatos()
    {
        Console.WriteLine($"Empleado {nombre}, edad {edad}, salario {salario}, antiguedad {antiguedad}");
    }
    }

public class Supervisor : Empleado
{
    public string region;

    public Supervisor(string nombre, int edad, int salario, int antiguedad, string region)
        : base(nombre, edad, salario, antiguedad)
    {
        this.region = region;
    }

    public new void mostrarDatos()
    {
        Console.WriteLine($"Supervisor {nombre}, edad {edad}, salario {salario}, antiguedad {antiguedad}, region {region}");
    }
}

public class Servicio : Empleado
{
    public string area;

    public Servicio(string nombre, int edad, int salario, int antiguedad, string area)
        : base(nombre, edad, salario, antiguedad)
    {
        this.area = area;
    }
    public new void mostrarDatos()
    {
        Console.WriteLine($"Servicio al cliente {nombre}, edad {edad}, salario {salario}, antiguedad {antiguedad}, area {area}");
    }
}

public class Vendedor : Empleado
{
    public string tipo;

    public Vendedor(string nombre, int edad, int salario, int antiguedad, string tipo)
        : base(nombre, edad, salario, antiguedad)
    {
        this.tipo = tipo;
    }

    public new void mostrarDatos()
    {
        Console.WriteLine($"Vendedor {nombre}, edad {edad}, salario {salario}, antiguedad {antiguedad}, tipo {tipo}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Empleado empleado2 = new Empleado("Edu", 20, 2500, 20);
        Empleado empleado = new Empleado("Fernando", 25, 2500, 10);
        Vendedor vendedor = new Vendedor("Alvaro", 39, 2000, 32, "Norte");
        Supervisor supervisor = new Supervisor("Joel", 23, 4000, 20, "BC");
        Servicio servicio = new Servicio("Eduardo", 25, 4500, 24, "Call center");
        empleado.mostrarDatos();
        empleado2.mostrarDatos();
        vendedor.mostrarDatos();
        supervisor.mostrarDatos();
        servicio.mostrarDatos();
    }
}
}
