using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase publica sellada (No hereda nada ni hereda de nadie)
    /// </summary>
    public sealed class Taller
    {
        /// <summary>
        /// Enumerado que contiene el tipo de vehiculo
        /// </summary>
        public enum ETipo
        {
            Ciclomotor, Sedan, SUV, Todos
        }

        private List<Vehiculo> vehiculos;
        private int espacioDisponible;


         #region "Constructores"
        /// <summary>
        /// Constructor privado que se encarga de inicializar la lista de vehiculos
        /// </summary>
        private Taller()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        /// <summary>
        /// Constructor publico que se encarga de inicializar la lista de vehiculos llamando al constructor
        /// de arriba, y ademas se encarga de inicializar el espacio disponible de la lista con lo que se
        /// le pasa como parametro.
        /// </summary>
        /// <param name="espacioDisponible"></param>
        public Taller(int espacioDisponible) : this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region "Sobrescritura"
        /// <summary>
        /// Muestro el estacionamiento y TODOS los vehículos
        /// </summary>
        /// <returns>Un string</returns>
        public override string ToString()
        {
            return Taller.Listar(this, ETipo.Todos);
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="taller">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns></returns>
        public static string Listar(Taller t, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", t.vehiculos.Count, t.espacioDisponible);
            sb.AppendLine("");
            foreach (Vehiculo v in t.vehiculos)
            {
                switch (tipo)
                {
                    case ETipo.Sedan:
                        if (v is Sedan)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    case ETipo.Ciclomotor:
                        if (v is Ciclomotor)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    case ETipo.SUV:
                        if (v is Suv)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    case ETipo.Todos:
                        if (v is Sedan)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        else
                        {
                            if (v is Ciclomotor)
                            {
                                sb.AppendLine(v.Mostrar());
                            }
                            else
                            {
                                if (v is Suv)
                                {
                                    sb.AppendLine(v.Mostrar());
                                }
                            }
                        }
                        break;
                }
            }

            return sb.ToString();
        }
        #endregion

        #region "Sobrecarga de Operadores"
        /// <summary>
        /// Sobrecarga que se encaega de agregar un elemento a la lista
        /// </summary>
        /// <param name="taller">Objeto donde se agregará el elemento</param>
        /// <param name="vehiculo">Objeto a agregar</param>
        /// <returns></returns>
        public static Taller operator +(Taller taller, Vehiculo vehiculo)
        {
            if(!(taller is null) && !(vehiculo is null))
            {
                if(taller.vehiculos.Count < taller.espacioDisponible)
                {
                    foreach (Vehiculo v in taller.vehiculos)
                    {
                        if (v == vehiculo)
                        {
                            return taller;
                        }
                    }
                    taller.vehiculos.Add(vehiculo);
                }
            }
            return taller;
        }
        /// <summary>
        /// Sobrecarga que se encarga de quitar el elemento de la lista
        /// </summary>
        /// <param name="taller">Objeto donde se quitará el elemento</param>
        /// <param name="vehiculo">Objeto a quitar</param>
        /// <returns></returns>
        public static Taller operator -(Taller taller, Vehiculo vehiculo)
        {
            if(!(taller is null && vehiculo is null))
            {
                if(taller.vehiculos.Count > 0)
                {
                    foreach (Vehiculo v in taller.vehiculos)
                    {
                        if (v == vehiculo)
                        {
                            taller.vehiculos.Remove(vehiculo);
                            break;
                        }
                    }
                }
            }
            return taller;
        }
        #endregion
    }
}
