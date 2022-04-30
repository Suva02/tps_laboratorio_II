using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    /// <summary>
    /// Clase publica que hereda de la clase vehiculo
    /// </summary>
    public class Sedan : Vehiculo
    {
        /// <summary>
        /// Enumerado que contiene la cantidad de puertas que puede tener un sedan
        /// </summary>
        public enum ETipo {CuatroPuertas, CincoPuertas }
        private ETipo tipo;

        /// <summary>
        /// Constructor parametrizado que se encarga de inicializar la cantidad de puertas con un valor
        /// predeterminado, y llamar al constructor de la clase base para inicializar los datos 
        /// que le corresponden al vehiculo
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
            this.tipo = ETipo.CuatroPuertas;
        }

        /// <summary>
        /// Sobrecarga de constructor, que se encarga de llamar al constructor de arriba con la diferencia
        /// que en esta sobrecarga, se inicializa el tipo de vehiculo con cierta cantidad de puertas con
        /// lo que se le pasa como parametro.
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        /// <param name="tipo"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo)
            : this(marca, chasis, color)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Retorna el tamaño de un Sedan
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }


        /// <summary>
        /// Metodo sobrescrito que se encarga de mostrar los datos del Sedan
        /// </summary>
        /// <returns>Un string</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar());
            sb.Append($"TAMAÑO : {this.Tamanio}");
            sb.AppendLine("TIPO : " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
