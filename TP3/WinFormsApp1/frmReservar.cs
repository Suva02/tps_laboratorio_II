using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Suetta.Valentin._2C.TPFinal;

namespace WinFormsApp1
{
    public partial class frmReservar : Form
    {
        string nuevaRuta;
        public List<Cliente> listaReservaClientes;
        public frmReservar()
        {
            InitializeComponent();
            this.nuevaRuta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            this.listaReservaClientes = new List<Cliente>();
        }

        /// <summary>
        /// BOTON PARA MOSTRAR VEHICULOS RESERVADOS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarVehiculos_Click(object sender, EventArgs e)
        {
            string path = "VehiculosDisponibles.json";
            List<Vehiculos> listaVehiculos;
            Vehiculos vehiculo;
            try
            {
                listaVehiculos = new List<Vehiculos>();
                vehiculo = new Vehiculos();
                vehiculo.VehiculosHardcodeados(listaVehiculos);
                Serializador<List<Vehiculos>> serializador = new Serializador<List<Vehiculos>>();
                serializador.Guardar_SerializarJSON(listaVehiculos, path);
                this.lstListaVehiculos.DataSource = serializador.Leer_Deserializar(path);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// EVENTO QUE PERMITE SELECCIONAR DATOS DANDOLE DOBLE CLICK AL LISTBOX
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstListaVehiculos_DoubleClick(object sender, EventArgs e)
        {
            Vehiculos? vehiculo;
            try
            {
                vehiculo = this.lstListaVehiculos.SelectedItem as Vehiculos;
                if (vehiculo is not null)
                {
                    txtVehiculo.Text = vehiculo.Marca;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// BOTON PARA GUARDAR UNA RESERVA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFinalizarReserva_Click(object sender, EventArgs e)
        {
            string path = "Reservas.json";
            try
            {
                Cliente cliente = new Cliente(txtNombre.Text, txtApellido.Text,txtDni.Text,txtDireccion.Text,txtTelefono.Text,txtVehiculo.Text);
                if(cliente.validarString(txtNombre.Text))
                {
                    MessageBox.Show("Nombre no valido!");
                }
                else
                {
                    if (cliente.validarString(txtApellido.Text))
                    {
                        MessageBox.Show("Apellido no valido!");
                    }
                    else
                    {
                        if (cliente.validarDni(txtDni.Text))
                        {
                            MessageBox.Show("Dni no valido!");
                        }
                        else
                        {
                            if (cliente.validarDireccion(txtDireccion.Text))
                            {
                                MessageBox.Show("Direccion no valida!");
                            }
                            else
                            {
                                if (cliente.validarTelefono(txtTelefono.Text))
                                {
                                    MessageBox.Show("Telefono no valido!");
                                }
                                else
                                {
                                    if (cliente.validarVehiculoSeleccionado(txtVehiculo.Text))
                                    {
                                        MessageBox.Show("Debe seleccionar un vehiculo!");
                                    }
                                    else
                                    {
                                        this.listaReservaClientes.Add(cliente);
                                        Serializador<List<Cliente>> serializador = new Serializador<List<Cliente>>();
                                        serializador.Guardar_SerializarJSON(this.listaReservaClientes, path);
                                        MessageBox.Show("Se reservo su vehiculo correctamente!");
                                        this.LimpiarDatos();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// METODO PARA LIMPIAR LOS DATOS DE LOS TEXTBOX
        /// </summary>
        private void LimpiarDatos()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDni.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtVehiculo.Text = string.Empty;
        }

        /// <summary>
        /// BOTON PARA VOLVER AL FORMULARIO PRINCIPAL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVolverAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
