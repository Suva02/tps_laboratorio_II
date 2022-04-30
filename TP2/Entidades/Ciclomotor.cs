using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase publica que hereda de la clase vehiculo
    /// </summary>
    public class Ciclomotor : Vehiculo
    {
        /// <summary>
        /// Constructor parametrizado que se encarga de llamar al constructor de la clase base para
        /// inicializar los campos como corresponde, pasandole los parametros recibidos en el constructor.
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color) : base(chasis, marca, color)
        {
        }

        /// <summary>
        /// Propiedad redefinida que se encarga de retornar el tamaño de un ciclomotor
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }

        /// <summary>
        /// Metodo redefinido que se encarga de mostrar los datos de un ciclomotor
        /// </summary>
        /// <returns>Un string</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());
            sb.Append($"TAMAÑO : {this.Tamanio}");
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
