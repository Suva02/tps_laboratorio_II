using System;
using System.Text;

namespace Suetta.Valentin._2C.TPFinal
{
    public class Cliente : ICorrect
    {
        private string nombre;
        private string apellido;
        private string dni;
        private string direccion;
        private string numeroTelefono;
        private string vehiculoReservado;

        public Cliente()
        {
           
        }
        public Cliente(string nombre, string apellido, string dni, string direccion, string numero, string vehiculo) : this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.direccion = direccion;
            this.numeroTelefono = numero;
            this.vehiculoReservado = vehiculo;
        }

        /// <summary>
        /// PROPIEDAD DE ESCRITURA-LECTURA DEL NOMBRE DEL CLIENTE
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        /// <summary>
        /// PROPIEDAD DE ESCRITURA-LECTURA DEL APELLIDO DEL CLIENTE
        /// </summary>
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        /// <summary>
        /// PROPIEDAD DE ESCRITURA-LECTURA DEL DNI DEL CLIENTE
        /// </summary>
        public string Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        /// <summary>
        /// PROPIEDAD DE ESCRITURA-LECTURA DE LA DIRECCION DEL CLIENTE
        /// </summary>
        public string Direccion
        {
            get
            {
                return this.direccion;
            }
            set
            {
                this.direccion = value;
            }
        }

        /// <summary>
        /// PROPIEDAD DE ESCRITURA-LECTURA DEL NUMERO DE TELEFONO DEL CLIENTE
        /// </summary>
        public string NumeroTelefono
        {
            get
            {
                return this.numeroTelefono;
            }
            set
            {
                this.numeroTelefono = value;
            }
        }

        public string VehiculoReservado
        {
            get
            {
                return this.vehiculoReservado;
            }
            set
            {
                this.vehiculoReservado = value;
            }
        }

        /// <summary>
        /// SOBREESCRITURA QUE RETORNA LOS DATOS COMPLETOS DE UN CLIENTE
        /// </summary>
        /// <returns>STRING</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("");
            sb.AppendLine($"Cliente: {this.Nombre} {this.Apellido}");
            sb.AppendLine($" Dni: {this.Dni}");
            sb.AppendLine($" Telefono: {this.NumeroTelefono}");
            sb.AppendLine($" Direccion: {this.Direccion}");
            sb.AppendLine($" Vehiculo reservado: {this.VehiculoReservado}");
            return sb.ToString();
        }

        /// <summary>
        /// METODO QUE SE ENCARGA DE VALIDAR UNA CADENA (SI CONTIENE NUMEROS, ES VACIA O 
        /// CONTIENE ESPACIOS)
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns>TRUE O FALSE</returns>
        public bool validarString(string cadena)
        {
            int numero;
            bool retorno = false;

            try
            {
                if (int.TryParse(cadena, out numero) || cadena == string.Empty || cadena.Contains(" "))
                {
                    retorno = true;
                }
            }
            catch(Exception)
            {
                throw;
            }
            return retorno;
        }
        /// <summary>
        /// METODO QUE SE ENCARGA DE VALIDAR UN DNI (SI ES UN NUMERO, SI ESTA VACIO, 
        /// CONTIENE ESPACIOS O LA CANTIDAD DE DIGITOS ES MENOR O MAYOR AL NUMERO DE UN DNI)
        /// </summary>
        /// <param name="dni"></param>
        /// <returns>TRUE O FALSE</returns>
        public bool validarDni(string dni)
        {
            int numero;
            bool retorno = false;

            try
            {
                if (!int.TryParse(dni, out numero) || dni == string.Empty || dni.Contains(" ") || dni.Length < 8 || dni.Length > 8)
                {
                    retorno = true;
                }
            }
            catch(Exception)
            {
                throw;
            }

            return retorno;
        }
        /// <summary>
        /// METODO QUE VALIDA UNA DIRECCION (SI ESTA VACIA)
        /// </summary>
        /// <param name="direccion"></param>
        /// <returns>TRUE O FALSE</returns>
        public bool validarDireccion(string direccion)
        {
            bool retorno = false;
            if (direccion == string.Empty)
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// METODO QUE VALIDA UN TELEFONO (SI ES UN NUMERO, ESTA VACIO,
        /// CONTIENE ESPACIOS O SUS DIGITOS SON MENORES O MAYORES A LOS DE UN NUMERO DE TELEFONO)
        /// </summary>
        /// <param name="telefono"></param>
        /// <returns>TRUE O FALSE</returns>
        public bool validarTelefono(string telefono)
        {
            int numero;
            bool retorno = false;
            try
            {
                if (!int.TryParse(telefono, out numero) || telefono == string.Empty || telefono.Contains(" ") || telefono.Length < 10 || telefono.Length > 10)
                {
                    retorno = true;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return retorno;
        }

        /// <summary>
        /// METODO QUE VALIDA UN VEHICULO (QUE NO ESTE VACIO)
        /// </summary>
        /// <param name="vehiculo"></param>
        /// <returns>TRUE O FALSE</returns>
        public bool validarVehiculoSeleccionado(string vehiculo)
        {
            bool retorno = false;
            if (vehiculo == string.Empty)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
