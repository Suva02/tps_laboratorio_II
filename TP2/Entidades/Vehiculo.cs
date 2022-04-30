using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase Base Abstracta.
    /// </summary>
    public abstract class Vehiculo
    {
        /// <summary>
        /// Enumerado que contiene la marca de los vehiculos
        /// </summary>
        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }
        /// <summary>
        /// Enumerado que contiene el tamaño de los vehiculos
        /// </summary>
        public enum ETamanio
        {
            Chico, Mediano, Grande
        }

        private EMarca marca;
        private string chasis;
        private ConsoleColor color;


        /// <summary>
        /// Constructor parametrizado que se encarga de inicializar los atributos con lo que se le pasa
        /// como parametro.
        /// </summary>
        /// <param name="chasis"></param>
        /// <param name="marca"></param>
        /// <param name="color"></param>
        public Vehiculo(string chasis, EMarca marca, ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;
        }

        /// <summary>
        /// Propiedad abstracta que retorna el tamaño del vehiculo
        /// </summary>
        protected abstract ETamanio Tamanio { get; }

        /// <summary>
        /// Metodo virtual que se encarga de castear un objeto utilizando la conversion explicita para poder
        /// mostrar los datos de un vehiculo
        /// </summary>
        /// <returns>Un string</returns>
        public virtual string Mostrar()
        {
            return ((string)this);
        }

        /// <summary>
        /// Sobrecarga de conversion que se encarga de retornar los datos de un vehiculo en formato string
        /// para luego castearlo y mostrarlo.
        /// </summary>
        /// <param name="p"></param>
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("CHASIS: {0}\n", p.chasis);
            sb.AppendFormat("MARCA: {0}\n", p.marca);
            sb.AppendFormat("COLOR: {0}\n", p.color);
            sb.AppendFormat("---------------------\n");

            return sb.ToString();
        }

        /// <summary>
        /// Sobrecarga del operador '==' que se fija el chasis de los dos vehiculos. Si son iguales, retorna
        /// "true"
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns>Un boolean</returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }
        /// <summary>
        /// Sobrecarga opuesta al operador '==' que se encarga de utilizar la sobrecarga que se encarga de 
        /// devolver true si los vehiculos son iguales pero negando la condicion por si no llegan a serlo. 
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns>Un boolean</returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}
