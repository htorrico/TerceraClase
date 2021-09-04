using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerceraClase2
{
  public  class Empleado
    {
       
        public string CodigoEmpleado { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public decimal SueldoBruto { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaIngreso { get; set; }

        public string RetornarNombreCompleto()
        {

            //PrimerApellido + Segundo Apellido + Primer Nombre + Segundo Nombre
            string resultado = "";

            //resultado = PrimerApellido + " " + SegundoApellido + " " + PrimerApellido + " " + SegundoNombre;
            resultado = string.Concat(PrimerApellido, " ", SegundoApellido, " ", PrimerNombre, " ", SegundoNombre);

            return resultado;
        }

        public decimal RetornarAporte()
        {
            decimal resultado = 0.0m;
            resultado = SueldoBruto * 0.13m;
            return resultado;
        }


        public decimal RetornarSueldoNeto()
        {
            //SueldoNeto = SueldoBruto - AporteAFP
            decimal resultado = 0.0m;
            resultado = SueldoBruto - RetornarAporte();
            return resultado;
        }

    }
}
