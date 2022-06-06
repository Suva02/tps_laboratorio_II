using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Suetta.Valentin._2C.TPFinal
{
    public class Serializador<T> where T: class, new()
    {
        string pathEscritorio;

        public Serializador()
        {
            this.pathEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        /// <summary>
        /// METODO QUE SE ENCARGA DE ESCRIBIR EN UN ARCHIVO CON FORMATO JSON
        /// </summary>
        /// <param name="objeto"></param>
        /// <param name="path"></param>
        public void Guardar_SerializarJSON(T objeto, string path)
        {
            string pathNuevo = $"{this.pathEscritorio}\\{path}";
            string cadenaJson;
            try
            {
                JsonSerializerOptions opciones = new JsonSerializerOptions();
                opciones.WriteIndented = true;

                cadenaJson = JsonSerializer.Serialize(objeto, opciones);
                File.WriteAllText(pathNuevo, cadenaJson);
            }
            catch(Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// METODO QUE SE ENCARGA DE LEER O DESERIALIZAR UN ARCHIVO CON FORMATO JSON
        /// </summary>
        /// <param name="path"></param>
        /// <returns>UN GENERICO</returns>
        public T Leer_Deserializar(string path)
        {
            string pathNuevo = $"{this.pathEscritorio}\\{path}";
            T objeto;
            try
            {
                string jsonString = File.ReadAllText(pathNuevo);
                objeto = JsonSerializer.Deserialize<T>(jsonString);
            }
            catch(Exception)
            {
                throw;
            }
            return objeto;
        }

        /// <summary>
        /// METODO QUE SE ENCARGA DE MODIFICAR UN OBJETO DE TIPO CLIENTE
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="path"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="telefono"></param>
        /// <param name="direccion"></param>
        /// <param name="vehiculo"></param>
        public void Modificar(Cliente cliente, string path,string nombre, string apellido, string dni, string telefono,string direccion, string vehiculo)
        {
            string pathNuevo = $"{this.pathEscritorio}\\{path}";
            string cadenaJson;

            try
            {
                JsonSerializerOptions opciones = new JsonSerializerOptions();
                opciones.WriteIndented = true;


                cliente.Nombre = nombre;
                cliente.Apellido = apellido;
                cliente.Dni = dni;
                cliente.NumeroTelefono = telefono;
                cliente.Direccion = direccion;
                cliente.VehiculoReservado = vehiculo;

                cadenaJson = JsonSerializer.Serialize(cliente, opciones);
                File.WriteAllText(pathNuevo, cadenaJson);
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}

