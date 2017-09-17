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
            nuevoUsuario.Dni = "4657981";
            nuevoUsuario.Edad = 33;
            Tablas.Usuario.Add(nuevoUsuario);
            Telefono nuevoTelefono = new Telefono();
            nuevoTelefono.Marca = "Samsung";
            nuevoTelefono.Modelo = "Galaxy S8";
            nuevoTelefono.numeroTelefonico = 97864531;
            nuevoTelefono.FechaDeLanzamiento = DateTime.Now;
            Tablas.Telefono.Add(nuevoTelefono);
            AplicacionesMoviles App = new AplicacionesMoviles();
            App.Nombre = "Facebook";
            Tablas.Aplicacion.Add(App);
            nuevoTelefono.App.Add(App);
            Tablas.SaveChanges();
        }
    }
}
