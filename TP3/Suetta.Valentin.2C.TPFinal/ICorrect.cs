using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suetta.Valentin._2C.TPFinal
{
    public interface ICorrect
    {
        
        public bool validarString(string cadena);
        public bool validarDni(string dni);
        public bool validarDireccion(string direccion);
        public bool validarTelefono(string telefono);
        public bool validarVehiculoSeleccionado(string vehiculo);
    }
}
