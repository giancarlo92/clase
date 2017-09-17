using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseDeDatos.Contextos;
using BaseDeDatos.Modelos;

namespace Practicando3
{
    class Program
    {
        static void Main(string[] args)
        {
            Datos Tablas = new Datos();
            Usuario nuevoUsuario = new Usuario();
            nuevoUsuario.Nombre = "Pedro";
            nuevoUsuario.Apellidos = "Navaja";
            nuevoUsuario.Dni = "13246578";
            nuevoUsuario.Edad = 35;
            Tablas.Usuario.Add(nuevoUsuario);
            Tablas.SaveChanges();
        }
    }
}
