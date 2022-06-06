using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Suetta.Valentin._2C.TPFinal;

namespace WinFormsApp1
{
    public partial class frmEliminar : Form
    {
        List<Cliente> listaReserva;
        public frmEliminar()
        {
            InitializeComponent();
            this.listaReserva = new List<Cliente>();
        }

        /// <summary>
        /// BOTON QUE SE ENCARGA DE MOSTRAR LAS RESERVAS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarReservas_Click(object sender, EventArgs e)
        {
            string path = "Reservas.json";
            try
            {
                Serializador<List<Cliente>> serializador = new Serializador<List<Cliente>>();
                this.listaReserva = new(serializador.Leer_Deserializar(path));
                if(this.listaReserva.Count > 0)
                {
                    this.lstEliminarReserva.DataSource = this.listaReserva;
                }
                else
                {
                    MessageBox.Show("No hay reservas en la lista!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// BOTON QUE SE ENCARGA DE CERAR EL FORMULARIO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// BOTON QUE SE ENCARGA DE ELIMINAR UNA RESERVA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtNombreEliminar.Text) && !string.IsNullOrEmpty(txtApellidoEliminar.Text) && !string.IsNullOrEmpty(txtDniEliminar.Text) && !string.IsNullOrEmpty(txtDireccionEliminar.Text)
                    && !string.IsNullOrEmpty(txtTelefonoEliminar.Text) && !string.IsNullOrEmpty(txtVehiculoEliminar.Text))
                {

                    Cliente clienteSeleccionado = lstEliminarReserva.SelectedItem as Cliente;

                    if (clienteSeleccionado is not null)
                    {

                        this.listaReserva.Remove(clienteSeleccionado);
                        Serializador<List<Cliente>> serializador = new Serializador<List<Cliente>>();
                        serializador.Guardar_SerializarJSON(this.listaReserva, "Reservas.json");
                        MessageBox.Show("Se elimino la reserva correctamente!");
                    }
                    else
                    {
                        throw new Exception("Cliente seleccionado es nulo...");
                    }
                    this.ActualizarLstClientes();
                    this.LimpiarTextBox();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar obligatoriamente una reserva de la lista!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// METODO QUE SE ENCARGA DE VACIAR/LIMPIAR LOS TEXTBOX
        /// </summary>
        private void LimpiarTextBox()
        {
            txtNombreEliminar.Text = string.Empty;
            txtApellidoEliminar.Text = string.Empty;
            txtDniEliminar.Text = string.Empty;
            txtDireccionEliminar.Text = string.Empty;
            txtTelefonoEliminar.Text = string.Empty;
            txtVehiculoEliminar.Text = string.Empty;
        }

        /// <summary>
        /// METODO QUE SE ENCARGA DE ACTUALIZAR LA LISTA DE CLIENTES UNA VEZ ES 
        /// MODIFICADA
        /// </summary>
        private void ActualizarLstClientes()
        {
            Serializador<List<Cliente>> serializador;
            try
            {
                serializador = new Serializador<List<Cliente>>();
                lstEliminarReserva.DataSource = null;
                lstEliminarReserva.DataSource = serializador.Leer_Deserializar("Reservas.json");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// EVENTO QUE PERMITE DARLE DOBLE CLICK AL LIST BOX PARA SELECCIONAR DATOS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstEliminarReserva_DoubleClick(object sender, EventArgs e)
        {
            Cliente? cliente;
            try
            {
                cliente = this.lstEliminarReserva.SelectedItem as Cliente;
                if (cliente is not null)
                {
                    txtNombreEliminar.Text = cliente.Nombre;
                    txtApellidoEliminar.Text = cliente.Apellido;
                    txtDniEliminar.Text = cliente.Dni;
                    txtDireccionEliminar.Text = cliente.Direccion;
                    txtTelefonoEliminar.Text = cliente.NumeroTelefono;
                    txtVehiculoEliminar.Text = cliente.VehiculoReservado;
                }
                else
                {
                    throw new Exception("Cliente nulo...");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
