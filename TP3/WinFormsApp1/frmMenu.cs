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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// EVENTO PARA ABRIR EL FORMULARIO PARA RESERVAR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReservar_Click(object sender, EventArgs e)
        {
            frmReservar formReserva = new frmReservar();
            formReserva.ShowDialog();
        }

        /// <summary>
        /// EVENTO PARA ABRIR EL FORMULARIO DE MODIFICAR RESERVA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificarReserva_Click(object sender, EventArgs e)
        {

            frmModificar formModificar = new frmModificar();
            formModificar.ShowDialog();   
        }

        /// <summary>
        /// EVENTO PARA ABRIR EL FORMULARIO PARA ELIMINAR UNA RESERVA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarReserva_Click(object sender, EventArgs e)
        {

            frmEliminar formEliminar = new frmEliminar();
            formEliminar.ShowDialog();
        }
    }
}
