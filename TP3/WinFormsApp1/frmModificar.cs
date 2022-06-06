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
    public partial class frmModificar : Form
    {
        List<Cliente> listaReserva;
        public frmModificar()
        {
            InitializeComponent();
            this.listaReserva = new List<Cliente>();
        }

        /// <summary>
        /// BOTON PARA MOSTRAR VEHICULOS RESERVADOS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarReservados_Click(object sender, EventArgs e)
        {
            string path = "Reservas.json";
            try
            {
                Serializador<List<Cliente>> serializador = new Serializador<List<Cliente>>();
                this.listaReserva = new(serializador.Leer_Deserializar(path));
                if(this.listaReserva.Count > 0)
                {
                    this.lstVehiculosReservados.DataSource = this.listaReserva;
                }
                else
                {
                    MessageBox.Show("No hay reservas en la lista!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// BOTON PARA VOLVER ATRAS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAtrasModificar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// BOTON PARA MODIFICAR RESERVA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtNombreModificar.Text) && !string.IsNullOrEmpty(txtApellidoModificar.Text) && !string.IsNullOrEmpty(txtDniModificar.Text) && !string.IsNullOrEmpty(txtDireccionModificar.Text)
                    && !string.IsNullOrEmpty(txtTelefonoModificar.Text) && !string.IsNullOrEmpty(txtVehiculoModificar.Text))
                {
                    Cliente nuevoCliente = new Cliente(txtNombreModificar.Text, txtApellidoModificar.Text, txtDniModificar.Text, txtDireccionModificar.Text, txtTelefonoModificar.Text, txtVehiculoModificar.Text);

                    Cliente clienteSeleccionado = lstVehiculosReservados.SelectedItem as Cliente;

                    if (clienteSeleccionado is not null)
                    {

                        this.listaReserva.Add(nuevoCliente);
                        Serializador<List<Cliente>> serializador = new Serializador<List<Cliente>>();
                        serializador.Guardar_SerializarJSON(this.listaReserva, "Reservas.json");
                        MessageBox.Show("Se modifico la reserva correctamente!");
                    }
                    this.ActualizarLstClientes();
                    this.LimpiarTextBox();
                    
                }
                else
                {
                    MessageBox.Show("Debe seleccionar obligatoriamente una reserva de la lista!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// METODO PARA LIMPIAR TEXTBOX DE MODIFICAR
        /// </summary>
        private void LimpiarTextBox()
        {
            txtNombreModificar.Text = string.Empty;
            txtApellidoModificar.Text = string.Empty;
            txtDniModificar.Text = string.Empty;
            txtDireccionModificar.Text = string.Empty;
            txtTelefonoModificar.Text = string.Empty;
            txtVehiculoModificar.Text = string.Empty;
        }

        /// <summary>
        /// METODO PARA ACTUALIZAR LA LISTA DE CLIENTES UNA VEZ SE MODIFICO
        /// </summary>
        private void ActualizarLstClientes()
        {
            Serializador<List<Cliente>> serializador = null;
            try
            {
                serializador = new Serializador<List<Cliente>>();
                lstVehiculosReservados.DataSource = null;
                lstVehiculosReservados.DataSource = serializador.Leer_Deserializar("Reservas.json");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// EVENTO QUE PERMITE SELECCIONAR DATOS AL DARLE DOBLE CLICK AL LIST BOX
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstVehiculosReservados_DoubleClick(object sender, EventArgs e)
        {
            Cliente? cliente;
            try
            {
                cliente = this.lstVehiculosReservados.SelectedItem as Cliente;
                if (cliente is not null)
                {
                    txtNombreModificar.Text = cliente.Nombre;
                    txtApellidoModificar.Text = cliente.Apellido;
                    txtDniModificar.Text = cliente.Dni;
                    txtDireccionModificar.Text = cliente.Direccion;
                    txtTelefonoModificar.Text = cliente.NumeroTelefono;
                    txtVehiculoModificar.Text = cliente.VehiculoReservado;
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
