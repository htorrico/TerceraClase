using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerceraClase2
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado();

            //Obtener Datos
            Console.WriteLine("Ingrese Primer Apellido");
            empleado.PrimerApellido = Console.ReadLine();

            Console.WriteLine("Ingrese Segundo Apellido");
            empleado.SegundoApellido = Console.ReadLine();

            Console.WriteLine("Ingrese Primer Nombre");
            empleado.PrimerNombre = Console.ReadLine();

            Console.WriteLine("Ingrese Segundo Nombre");
            empleado.SegundoNombre = Console.ReadLine();

            Console.WriteLine("Ingrese Segundo Bruto");
            empleado.SueldoBruto =Convert.ToDecimal( Console.ReadLine());

            //Calcular Datos
            string NombreCompleto = empleado.RetornarNombreCompleto();
            decimal SueldoNeto = empleado.RetornarSueldoNeto();


            //Mostrar Datos
            Console.WriteLine("El nombre completo es:"+ NombreCompleto );
            Console.WriteLine("El sueldo neto es:" + SueldoNeto);


            Console.Read();
        }
    }
}
