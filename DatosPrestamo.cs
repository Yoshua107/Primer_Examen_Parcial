using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Examen_Parcial
{
    class DatosPrestamo
    {
        string carnet;
        string codigo_del_Libro;
        DateTime Fecha_de_Prestamo;
        DateTime Fecha_de_Devolucion;

        public string Carnet { get => carnet; set => carnet = value; }
        public string Codigo_del_Libro { get => codigo_del_Libro; set => codigo_del_Libro = value; }
        public DateTime Fecha_de_Prestamo1 { get => Fecha_de_Prestamo; set => Fecha_de_Prestamo = value; }
        public DateTime Fecha_de_Devolucion1 { get => Fecha_de_Devolucion; set => Fecha_de_Devolucion = value; }
    }
}
