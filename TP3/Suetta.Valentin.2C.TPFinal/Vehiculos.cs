using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suetta.Valentin._2C.TPFinal
{
    public class Vehiculos
    {
        private string marca;

        public Vehiculos()
        {
            this.marca = string.Empty;
        }

        public string Marca
        {
            get
            {
                return this.marca;
            }
            set
            {
                this.marca = value;
            }
        }

        /// <summary>
        /// METODO SOBREESCRITO QUE RETORNA UNA CADENA CON LOS DATOS DE UN VEHICULO
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("");
            sb.AppendLine(this.Marca);
            return sb.ToString();
        }

        /// <summary>
        /// METODO QUE SE ENCARGA DE AGREGAR VEHICULOS A LA LISTA (MANUALMENTE)
        /// </summary>
        /// <param name="listaVehiculos"></param>
        public void VehiculosHardcodeados(List<Vehiculos> listaVehiculos)
        {
            Vehiculos mercedesBenz = new Vehiculos()
            {
                Marca = "Mercedes-Benz 3.0"
            };
            Vehiculos bmwZ4 = new Vehiculos()
            {
                Marca = "BMW Serie 5 3.2"
            };
            Vehiculos audiA6 = new Vehiculos()
            {
                Marca = "Audi A6 3.0"
            };
            Vehiculos alfaRomeo = new Vehiculos()
            {
                Marca = "Alfa Romeo 2.0"
            };
            Vehiculos Amarok = new Vehiculos()
            {
                Marca = "Amarok 4.2"
            };
            Vehiculos audiTt = new Vehiculos()
            {
                Marca = "Audi TT 3.5"
            };
            Vehiculos tesla = new Vehiculos()
            {
                Marca = "Tesla 2.0"
            };
            Vehiculos hyundai = new Vehiculos()
            {
                Marca = "Hyundai 2.0"
            };
            Vehiculos bora = new Vehiculos()
            {
                Marca = "Bora 1.8 TDI"
            };
            Vehiculos Psiroco = new Vehiculos()
            {
                Marca = "Psiroco 2.5"
            };

            listaVehiculos.Add(mercedesBenz);
            listaVehiculos.Add(bmwZ4);
            listaVehiculos.Add(audiA6);
            listaVehiculos.Add(alfaRomeo);
            listaVehiculos.Add(Amarok);
            listaVehiculos.Add(audiTt);
            listaVehiculos.Add(tesla);
            listaVehiculos.Add(hyundai);
            listaVehiculos.Add(bora);
            listaVehiculos.Add(Psiroco);

        }
    }
}
