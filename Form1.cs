using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primer_Examen_Parcial
{
    public partial class Form1 : Form
    {
        List<DatosPrestamo> prestamos = new List<DatosPrestamo>();
        List<Libro> Libros = new List<Libro>();
        List<Alumno> Alumnos = new List<Alumno>();

        public Form1()
        {
            InitializeComponent();
        }

        void Guardar_Prestamo()
        {
            FileStream fs = new FileStream("DatosPrestamo.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            foreach (var cs in prestamos)
            {
                sw.WriteLine(cs.Carnet);
                sw.WriteLine(cs.Codigo_del_Libro);
                sw.WriteLine(cs.Fecha_de_Prestamo1);
                sw.WriteLine(cs.Fecha_de_Devolucion1);
            }
            sw.Close();

        }
        void Cargar_Prestamo()
        {
            FileStream fs = new FileStream("DatosPrestamo.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while (sr.Peek() > -1)
            {
                DatosPrestamo datos = new DatosPrestamo();
                datos.Carnet = sr.ReadLine();
                datos.Codigo_del_Libro = sr.ReadLine();
                datos.Fecha_de_Prestamo1 = DateTime.Parse(sr.ReadLine());
                datos.Fecha_de_Devolucion1 = DateTime.Parse(sr.ReadLine());

                prestamos.Add(datos);
            }
            sr.Close();
        }

        void cargar_datos_ALUMNO()
        {
            FileStream fs = new FileStream("DatosAlumno.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while (sr.Peek() > -1)
            {
                Alumno dato = new Alumno();
                dato.Carnet1 = sr.ReadLine();
                dato.Nombre1 = sr.ReadLine();
                dato.Direccion1 = sr.ReadLine();

                Alumnos.Add(dato);
            }
            sr.Close();

        }
        void cargar_datos_Libro()
        {
            FileStream fs = new FileStream("DatosLibro.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while (sr.Peek() > -1)
            {
                Libro dato = new Libro();
                dato.Codigo1 = sr.ReadLine();
                dato.Titulo1 = sr.ReadLine();
                dato.Autor1 = sr.ReadLine();
                dato.Año1 = sr.ReadLine();

                Libros.Add(dato);
            }
            sr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatosPrestamo datos = new DatosPrestamo();
            if (texCarnet.Text=="" || texCodigo.Text == "" )
            {
                MessageBox.Show("Llenar todos los campos de texto, para poder agregar los datos");
            }
            else
            {
                datos.Carnet = texCarnet.Text;
                datos.Codigo_del_Libro = texCodigo.Text;
                datos.Fecha_de_Prestamo1 = dateTimePrestamo.Value;
                datos.Fecha_de_Devolucion1 = dateTimeDevolucion.Value;

                prestamos.Add(datos);
                Guardar_Prestamo();
            }
        }
    }
}
